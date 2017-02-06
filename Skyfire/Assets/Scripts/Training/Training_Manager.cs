using UnityEngine;
using System.Collections;

public class Training_Manager : MonoBehaviour {

	public static int fighter;
	public static int archer;

	// Use this for initialization
	void Start () {
		fighter = 0;
		archer = 0;
	}

	public void training(string soldier){
		switch (soldier) {
		case "fighter":
			fighter++;
			break;
		case "archer":
			archer++;
			break;
		}
	}
}
