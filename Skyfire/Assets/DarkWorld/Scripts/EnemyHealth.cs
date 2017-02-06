using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 100;
	public int enemyCurrentHealth;
	public Slider EnemyHealthSlider;

	Animator anim;
	bool isDead;



	void Awake ()
	{
		anim = GetComponent <Animator> ();
		enemyCurrentHealth = startingHealth;
	}


	void Update ()
	{
		
	}


	public void eTakeDamage (int amount)
	{
		if(isDead)
			return;

		enemyCurrentHealth -= amount;

		EnemyHealthSlider.value = enemyCurrentHealth;

		if(enemyCurrentHealth <= 0 && isDead!=true)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;
		anim.SetBool("Dead",true);
	}



}
