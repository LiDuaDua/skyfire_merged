using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	public float timeBetweenAttacks = 0.5f;
	public int attackDamage=10;
	public float playerEnemyDistance;


	Animator anim;
	GameObject player;
	GameObject enemy;
	PlayerHealth playerHealth;  //Reference to player's health
	EnemyHealth enemyHealth;   //Reference to enemy's health
	bool playerInRange;
	float timer;

	// Use this for initialization
	void Start () {
		playerEnemyDistance = 2f;
		player = GameObject.FindGameObjectWithTag ("Player");
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
		playerHealth = player.GetComponent<PlayerHealth> ();
		enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent<Animator> ();
	}


	void PlayerInSight()
	{
		float dis = Mathf.Abs(player.transform.position.x - enemy.transform.position.x);
		//if the entering collider is the player
		if (dis<=playerEnemyDistance) 
		{
			//The player is in range
			playerInRange=true;

		}else{
			playerInRange=false;
		}
	}




	// Update is called once per frame
	void Update () {
		//Add the time since Update was last called to the timer
		timer += Time.deltaTime;

		PlayerInSight ();

		//if the timer exceeds the time between attacks, the player is in range and this enemy is alive
		if (timer >= timeBetweenAttacks && playerInRange && enemyHealth.enemyCurrentHealth > 0) 
		{
			Attack ();
		}

		if (playerHealth.currentHealth <= 0) 
		{
			anim.SetTrigger ("Idle");
		}
	}

	void Attack()
	{
		timer = 0f;

		if (playerHealth.currentHealth > 0) 
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}

}
