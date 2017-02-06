using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class show_coins : MonoBehaviour {
	Text coinsNum;


	// Use this for initialization
	void Start () {
		coinsNum = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		coinsNum.text = Property.coins + "";
	}
}
