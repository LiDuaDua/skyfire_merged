using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Bread_Shower : MonoBehaviour {

	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = Exploration_Manager.bread + "";
	}
}
