using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TreeCollider : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D some){
		if (some.gameObject.tag == "Player") {
			CharacterPos.pos = GameObject.FindGameObjectWithTag ("Fight").transform.position;

			CharacterPos.pos.y -= 1.2f;

			SceneManager.LoadScene("Scenes/TowerDefence", LoadSceneMode.Single);
			Debug.Log ("kjasdhfkl");
		}
	}
}
