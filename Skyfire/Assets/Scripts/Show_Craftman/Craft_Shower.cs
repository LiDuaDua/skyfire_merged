using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Craft_Shower : MonoBehaviour {
	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = Craftman_Manager.used_cft + "/" + Craftman_Manager.num_cf;
	}
}
