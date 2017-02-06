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
			SceneManager.LoadScene("Scenes/level1", LoadSceneMode.Single);
			Debug.Log ("kjasdhfkl");
		}
	}
}
