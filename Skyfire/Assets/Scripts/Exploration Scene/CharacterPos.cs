using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterPos : MonoBehaviour {

	public static Vector3 pos;
	public static Vector3 tentPos;

	void Awake(){
		tentPos = GameObject.FindGameObjectWithTag ("Tent").transform.position;

		tentPos.y -= 2.2f;
		tentPos.x += 0.5f;

		Debug.Log (tentPos.x);
	}

	public static void setTent(){
		pos = tentPos;
	}

}
