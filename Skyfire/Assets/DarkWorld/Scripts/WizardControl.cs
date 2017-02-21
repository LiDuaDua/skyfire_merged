using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour {

	private GameObject wizard;
	Animator anim;
	public bool isOnGround;
	public float attackDistance = 5;
	GameObject enemy;

	public float HP = 5;
	public float currentHP =0;
	public int damage = 1;
	public float speed = 2; 
	float timer;
	public float timeBetweenAttack=1f;


	// Use this for initialization
	void Start () {

		wizard = this.gameObject;
		anim = GetComponent<Animator> ();
		currentHP = HP;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		float cal_hp = currentHP / HP;
		SetBar (cal_hp);
		if (isOnGround) {
			if (currentHP <= 0) {
				die ();
			}
				
			if (meetAnemy()) {
				if(timer > timeBetweenAttack){

					Attack ();
				}
			} else {
				anim.SetBool ("Attack", false);
				anim.SetBool ("Idle", true);
			}


		}
	}

	public void die(){
		anim.SetBool ("Dead",true);
		isOnGround = false;//unable fighter
		Invoke("distroy", 3);
	}

	private void distroy(){
		GameObject.Destroy (this.gameObject);
	}


	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Platform") {
			isOnGround = true;
		}
	}

	public bool meetAnemy(){
		Collider2D enemies = Physics2D.OverlapCircle (transform.position, attackDistance, 1 << LayerMask.NameToLayer("Enemies"));
		if (enemies != null) {
			this.enemy = enemies.gameObject;

			return true;
		}
		return false;
	}

	public void SetBar(float myHealth)
	{
		//soilderHealthBar.transform.localScale = new Vector3 (myHealth, soilderHealthBar.transform.localScale.y, soilderHealthBar.transform.localScale.z);
	}

	void Attack()
	{
		timer = 0;
		anim.SetBool("Attack",true);
		enemy.GetComponent<Enemy> ().currentHP -= damage;

	}
}
