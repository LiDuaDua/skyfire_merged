using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	public int playerAttackDamage=10;
	float timeBetweenAttacks=0.5f;

	GameObject player;
	GameObject enemy;
	EnemyAttack enemyAttack;
	EnemyHealth enemyHealth;

	Animator anim;
	bool enemyInRange;
	float timer;
	float attackTimer;


	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
		anim = GetComponent<Animator> ();
		enemyAttack = enemy.GetComponent<EnemyAttack> ();
		enemyHealth = enemy.GetComponent<EnemyHealth> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		timer += Time.deltaTime;

		EnemyInSight ();

		if (timer >= timeBetweenAttacks && enemyInRange && enemyHealth.enemyCurrentHealth > 0) 
		{
			if (Input.GetKey (KeyCode.J)) {
				anim.SetBool ("Attack", true);

				//stop looping by script
				anim.Play ("Attack", -1, 0f);
				Attack ();
			}
			anim.SetBool ("Attack", false);
		}


		if (enemyHealth.enemyCurrentHealth <= 0) 
		{
			anim.SetTrigger ("Idle");
		}
	}

	void EnemyInSight()
	{
		float dis = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
		if (dis <= enemyAttack.playerEnemyDistance ) {
			enemyInRange = true;
		} else {
			enemyInRange = false;
		}
	}

	void Attack()
	{
		timer = 0f;

		if (enemyHealth.enemyCurrentHealth > 0) 
		{
			enemyHealth.eTakeDamage (playerAttackDamage);
		}
	}

}
