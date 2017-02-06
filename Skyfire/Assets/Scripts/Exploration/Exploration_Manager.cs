using UnityEngine;
using System.Collections;

public class Exploration_Manager : MonoBehaviour {
	public static int backpack_size;
	public static int backpack_used;
	public static int bread;


	public static int team_size;
	public static int team_used;
	public static int archer;
	public static int fighter;
	


	// Use this for initialization
	void Start () {
		backpack_size = 15;
		backpack_used = 0;
		bread = 0;

		team_size = 10;
		backpack_used = 0;
		archer = 0;
		fighter = 0;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void depart(){
		Army.damage = 1 * fighter + 2 * archer;
		Army.HP = 2 * fighter + 1 * archer;

		Backpack.bread = bread;
		Backpack.size = backpack_size;
		Backpack.used = backpack_used;

		Debug.Log ("damage:" + Army.damage);
		Debug.Log ("HP:" + Army.HP);
	}

	public void addBread(){
		if (backpack_used < backpack_size && Property.bread > 0) {
			bread++;
			backpack_used++;
			Property.bread--;
		} else if (Property.bread == 0) {
			Debug.Log ("No enough bread");
		} else {
			Debug.Log ("Backpack is full!");
		}
	}

	public void removeBread(){
		if (bread > 0) {
			bread--;
			backpack_used--;
			Property.bread++;
		}
	}

	public void addFighter(){
		if (team_used < team_size && Training_Manager.fighter > 0) {
			fighter++;
			team_used++;
			Training_Manager.fighter--;
		} else if (Training_Manager.fighter == 0) {
			Debug.Log ("No enough fighter!");
		} else {
			Debug.Log ("Team is full");
		}
	}

	public void minusFighter(){
		if (fighter > 0) {
			fighter--;
			team_size++;
			Training_Manager.fighter++;
		}
	}

	public void addArcher(){
		if (team_used < team_size && Training_Manager.archer > 0) {
			archer++;
			team_used++;
			Training_Manager.archer--;
		} else if (Training_Manager.archer == 0) {
			Debug.Log ("No enough archer!");
		} else {
			Debug.Log ("Team is full");
		}
	}

	public void minusArcher(){
		if (archer > 0) {
			archer--;
			team_size++;
			Training_Manager.archer++;
		}
	}


}
