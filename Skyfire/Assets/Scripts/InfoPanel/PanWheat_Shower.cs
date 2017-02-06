using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PanWheat_Shower : MonoBehaviour {
	Text text;

	public void Start(){
		text = GetComponent<Text> ();
	}

	public void Update(){
		text.text = Property.wheat + "";
	}
}
