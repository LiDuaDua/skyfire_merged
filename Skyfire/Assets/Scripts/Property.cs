using UnityEngine;
using System.Collections;

public class Property : MonoBehaviour {

	public static int coins = 200;
	public static int bread = 200;
	public static int wheat = 200;

	public static int curArmySize = 0;
	//public static int curWorkingCf = 0;
	public static int maxArmySize = Building_Manager.camp * 5;
	public static int maxCraftman = Building_Manager.hut * 5;

	private float nextTime;
	private float interval;



	public void Start(){
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
