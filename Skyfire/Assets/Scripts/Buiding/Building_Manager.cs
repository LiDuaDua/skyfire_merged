using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Building_Manager : MonoBehaviour {
	public static int hut = 1;
	public static int camp = 0;

	public void add_hut(){
		if (Property.coins >= 20) {
			hut++;
			Craftman_Manager.num_cf = hut * 5;
			Property.coins -= 20;
		}
	}

	public void add_camp(){
		if (Property.coins >= 20) {
			camp++;
			Property.maxArmySize = camp * 10;
			Property.coins -= 20;
		}
	}
}
