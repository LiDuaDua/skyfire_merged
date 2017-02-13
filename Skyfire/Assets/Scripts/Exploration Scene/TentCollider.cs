using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TentCollider : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D some)
    {
        if (some.gameObject.tag == "Player")
        {
			CharacterPos.setTent ();

            SceneManager.LoadScene("Scenes/DarkWorld", LoadSceneMode.Single);
            
        }
    }
}
