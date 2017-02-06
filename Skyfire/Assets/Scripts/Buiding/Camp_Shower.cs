using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Camp_Shower : MonoBehaviour {
	public Text text;

	public void Start(){
		text = GetComponent<Text> ();
	}

	public void Update(){
		text.text = Building_Manager.camp + "";
	}
}
