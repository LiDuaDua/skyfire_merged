using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;



public class Draggable : MonoBehaviour,IDragHandler,IBeginDragHandler,IEndDragHandler {

	[SerializeField]
	private GameObject characterPrefab;

	public GameObject obj;

	public Camera camera;



	void start()
	{
		camera = GetComponent<Camera> ();
	}

	public GameObject CharacterPrefab
	{
		get
		{ 
			return characterPrefab;
		}
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		//Camera camera = GetComponent<Camera>();
//		Debug.Log ("Onbegindrag");

		if (characterPrefab.tag == "Fighter"  && Army.fighter > 0) {
			Army.fighter--;
			obj = Instantiate (characterPrefab, transform.position, transform.rotation) as GameObject;
			obj.transform.localScale = new Vector3 (-1.5f, 1.5f, -1);

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = -camera.transform.position.z;
			obj.transform.localPosition = camera.ScreenToWorldPoint (mousePos);
		}else if(characterPrefab.tag == "Archer" && Army.archer > 0){
			Army.archer--;
			obj = Instantiate (characterPrefab, transform.position, transform.rotation) as GameObject;
			obj.transform.localScale = new Vector3 (-1.5f, 1.5f, -1);

			Vector3 mousePos = Input.mousePosition;
			mousePos.z = -camera.transform.position.z;
			obj.transform.localPosition = camera.ScreenToWorldPoint (mousePos);
		}
		//obj.transform.position = Input.mousePosition;

	}
	public void OnDrag(PointerEventData eventData)
	{
		//Debug.Log (Input.mousePosition);

		//obj.transform.position = new Vector3(eventData.position.x,eventData.position.y,0);

		//obj.transform.localScale = new Vector3 (-100f, 100f, 1f);
		//obj.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -3);

		//Camera camera = GetComponent<Camera>();
		Vector3 evePos = eventData.position;
		evePos.z = - camera.transform.position.z;
		obj.transform.localPosition = camera.ScreenToWorldPoint (evePos);


	}

	public void OnEndDrag(PointerEventData eventData)
	{
		Debug.Log ("OnEnddrag");
//		obj = Instantiate(characterPrefab,transform.position,transform.rotation) as GameObject;
//
//		obj.transform.localScale = new Vector3 (-50, 50, -1);
//
//		//obj.transform.localScale = new Vector3 (-100f, 100f, 1f);
//		//obj.transform.position = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, -3);
//		obj.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
	}





}
