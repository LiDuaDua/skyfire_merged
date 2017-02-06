using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bread : MonoBehaviour {

	PlayerHealth playerHealth;
	GameObject player;
	//int bread;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void breadClicked()
	{
		//if (bread > 0) {
			playerHealth.currentHealth = playerHealth.startingHealth;
		//}
	}
}
