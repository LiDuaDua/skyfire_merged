using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterController : MonoBehaviour {

	public float HP = 5;
	public float currentHP =0;
	public int damage = 1;
	public float attackDistance = 2f;
	public float speed = 2;
	public Animator ani; 
	//public GameObject soilderHealthBar;


	public bool isOnGround;

	//private float interval = 0.2f;
	public float timeBetweenAttack = 1f;
	private GameObject enemy;
	float timer;

	public void Start(){
		ani = this.gameObject.GetComponent<Animator> ();
		currentHP = HP;
	}

	public void Update(){

		timer += Time.deltaTime;
		float cal_hp = currentHP / HP;
		SetBar (cal_hp);

		if (isOnGround) {
			if (meetAnemy()) {
				//attack;
				//ani.SetTrigger("Idle");

				if(timer > timeBetweenAttack){

					Attack ();
				}

			} else {
				//move;
				ani.SetBool("Attack",false);
				ani.SetBool("Walk",true);
				transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, 
					transform.position.y, transform.position.z);
			}

			if (currentHP <= 0) {
				die ();
			}
		}
	}

	public void die(){
		ani.SetBool ("Dead",true);
		isOnGround = false;//unable fighter
		GameObject.Destroy(this.GetComponent<Rigidbody2D>());
		Invoke("distroy", 3);
	}

	private void distroy(){
		GameObject.Destroy (this.gameObject);
	}

	public bool meetAnemy(){

		Collider2D enemies = Physics2D.OverlapCircle (transform.position, attackDistance, 1 << LayerMask.NameToLayer("Enemies"));
		if (enemies != null) {
			this.enemy = enemies.gameObject;

			return true;
		}
		return false;
	}

	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Platform") {
			isOnGround = true;
		}
	}

	public void SetBar(float myHealth)
	{
		//soilderHealthBar.transform.localScale = new Vector3 (myHealth, soilderHealthBar.transform.localScale.y, soilderHealthBar.transform.localScale.z);
	}

	void Attack()
	{
		timer = 0;
		ani.SetBool ("Walk", false);
		ani.SetBool("Attack",true);
		enemy.GetComponent<Enemy> ().currentHP -= damage;


	}
}
