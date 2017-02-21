using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInFight : MonoBehaviour {
	public int HP = 1;

	public void Update(){
		if (die ()) {
			Invoke("goHome", 3);
		}
	}

	private bool die(){
		return HP <= 0;
	}

	public void goHome(){
		CharacterPos.setTent ();

		SceneManager.LoadScene ("Scenes/DarkWorld", LoadSceneMode.Single);
	}

	public void escape(){
		SceneManager.LoadScene("Scenes/main", LoadSceneMode.Single);
	}
}
