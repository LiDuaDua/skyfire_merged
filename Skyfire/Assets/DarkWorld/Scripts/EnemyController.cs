using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour {



	public float MoveSpeed;
	public float MinDist;
	GameObject enemy;
	GameObject player;


	Animator anim;

	// Use this for initialization
	void Start () {

		player = GameObject.FindGameObjectWithTag ("Player");

		enemy = GameObject.FindGameObjectWithTag ("Enemy");

		anim = GetComponent<Animator> ();

		MinDist = 2f;

		MoveSpeed = 1f;


	}
	
	// Update is called once per frame
	void Update ()
	{
		//if (GetComponent<Rigidbody2D> ().position.x <= -6.5f) {
		//	GetComponent<Rigidbody2D> ().position = new Vector2 (-6.5f, GetComponent<Rigidbody2D> ().position.y);
		//} else if (GetComponent<Rigidbody2D> ().position.x >= 10f) {
		//	GetComponent<Rigidbody2D> ().position = new Vector2 (10f, GetComponent<Rigidbody2D> ().position.y);
		//}

		if (enemy.transform.position.x - player.transform.position.x >= MinDist) {
			
			enemy.transform.position += new Vector3 ((player.transform.position.x - enemy.transform.position.x), 0, player.transform.position.z) * MoveSpeed * Time.deltaTime;
			anim.SetTrigger ("Walk");
		} else {
			anim.SetTrigger ("Attack");
		}




	}


}
