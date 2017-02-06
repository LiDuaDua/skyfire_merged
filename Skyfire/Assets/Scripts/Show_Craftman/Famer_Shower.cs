using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Famer_Shower : MonoBehaviour {
	Text famerNum;

	// Use this for initialization
	void Start () {
		famerNum = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		famerNum.text = Craftman_Manager.famer + "";
	}
}
