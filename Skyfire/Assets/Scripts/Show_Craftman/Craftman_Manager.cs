using UnityEngine;
using System.Collections;

public class Craftman_Manager : MonoBehaviour {

	public Craftman_Manager cf_manager;

	public static int num_cf = Building_Manager.hut * 5;
	public static int used_cft = 0;

	public static int famer = 0;
	public static int cooker = 0;
	public static int miner = 0;
	public static int weaver = 0;
	
	// Update is called once per frame
	void Update () {
		
	}

	public void add(string job){
		switch(job){
		case "famer":
			if (used_cft < num_cf) {
				famer++;
				used_cft++;
			}
			break;
		case "cooker":
			if (used_cft < num_cf) {
				cooker++;
				used_cft++;
			}
			break;
		case "weaver":
			if (used_cft < num_cf) {
				weaver++;
				used_cft++;
			}
			break;
		case "miner":
			if (used_cft < num_cf) {
				miner++;
				used_cft++;
			}
			break;
		}
	}

	public void minus(string job){
		switch(job){
		case "famer":
			if (famer > 0) {
				used_cft--;
				famer--;
			}
			break;
		case "cooker":
			if (cooker > 0) {
				used_cft--;
				cooker --;
			}
			break;
		case "weaver":
			if (weaver > 0) {
				used_cft--;
				weaver --;
			}
			break;
		case "miner":
			if (miner > 0) {
				used_cft--;
				miner --;
			}
			break;
		}
	}




}
