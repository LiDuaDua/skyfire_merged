﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed=10f;
	bool facingRight=true;
	GameObject player;

	Animator anim;


	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		float move = Input.GetAxis ("Horizontal");

		//anim.SetFloat ("Speed", Mathf.Abs (move));

		GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

		if (Mathf.Abs(move) > 0.01) {
			anim.SetBool ("Walk", true);
			anim.SetBool ("Idle", false);
		} else {
			anim.SetBool ("Idle", true);
			anim.SetBool ("Walk", false);
		}

		if (move > 0 && !facingRight) {
			Flip ();
		} else if(move <0 && facingRight){
			Flip ();
		}
			

	}

	void Flip()
	{
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
