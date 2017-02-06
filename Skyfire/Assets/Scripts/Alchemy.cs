using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Alchemy : MonoBehaviour {
	private float interval;
	private float nextAlchemy;

	// Use this for initialization
	void Start () {
		interval = 0.5f;
		nextAlchemy = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextAlchemy) {
			GetComponent<Button> ().interactable = true;
		}
	}

	public void unableButton(){
		GetComponent<Button> ().interactable = false;
		nextAlchemy = Time.time + interval;
	}
}
