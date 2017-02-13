using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour {


	public float restartDelay = 2f;
	Animator anim;
	GameObject player;
	GameObject enemy;


	float restartTimer;

	PlayerHealth playerHealth;
	Animator eneAni;
	PlayerAttack playerAttack;   //Reference to the Animator component
	EnemyAttack enemyAttack;  //Reference to the PlayerShotting script
	EnemyController enemyController;
	PlayerController playerController;

	void Start()
	{
		anim = GetComponent<Animator>();
		player = GameObject.FindGameObjectWithTag ("Player");
		enemy = GameObject.FindGameObjectWithTag ("Enemy");
		playerHealth = player.GetComponent<PlayerHealth> ();
		playerController = player.GetComponent<PlayerController> ();
		playerAttack = player.GetComponent<PlayerAttack> ();
		enemyAttack = enemy.GetComponent<EnemyAttack> ();
		enemyController = enemy.GetComponent<EnemyController> ();



		eneAni = enemy.GetComponent<Animator>();

	}

	void Update()
	{
		if (playerHealth.currentHealth <= 0) {
			anim.SetBool ("Failed", true);

			restartTimer += Time.deltaTime;

			if (restartTimer >= restartDelay)
			{
				CharacterPos.setTent ();

				SceneManager.LoadScene ("Scenes/DarkWorld", LoadSceneMode.Single);
			}

			eneAni.SetTrigger ("Idle");
		}
	}

	public void clicked()
	{
		Debug.Log ("click!");
		anim.SetBool ("Failed", true);


		playerAttack.enabled = false;
		//enemyAttack.enabled = false;
		playerHealth.enabled = false;
		enemyController.enabled = false;
		playerController.enabled = false;
		//restartTimer += Time.deltaTime;

		SceneManager.LoadScene("Scenes/main", LoadSceneMode.Single);
	}


}
