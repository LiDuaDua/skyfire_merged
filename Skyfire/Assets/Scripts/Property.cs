using UnityEngine;
using System.Collections;

public class Property : MonoBehaviour {

	public static int coins;
	public static int bread;
	public static int wheat;

	private float nextTime;
	private float interval;



	public void Start(){
		coins = 0;
		nextTime = 0;
		interval = 3;
	}

	public void coinsAdd(){
		coinsAdd (1);
	}

	public void coinsAdd(int m){
		coins += m;
	}

	public void addWheat(){
		wheat += Craftman_Manager.famer;
	}

	public void addBread(){
		bread += Mathf.Min(Craftman_Manager.cooker, (int)(wheat/2));
	}

	public void addCoins(){
		coins += Craftman_Manager.miner;
	}

	public void Update(){
		if (Time.time > nextTime) {
			nextTime += interval;
			addBread ();
			addWheat ();
			addCoins ();
		}
	}
}
