using UnityEngine;
using System.Collections;

public class Training_Manager : MonoBehaviour {

	public static int fighter = 0;
	public static int archer = 0;

	public void training(string soldier){
		switch (soldier) {
		case "fighter":
			if (Property.coins >= Fighter.price && Property.curArmySize <= Property.maxArmySize - Fighter.size) {
				fighter++;
				Property.coins -= Fighter.price;
				Property.curArmySize += Fighter.size;
			}
			break;
		case "archer":
			if (Property.coins >= Fighter.price && Property.curArmySize <= Property.maxArmySize - Archer.size) {
				archer++;
				Property.coins -= Archer.price;
				Property.curArmySize += Archer.size;
			}
			break;
		}
	}
}
