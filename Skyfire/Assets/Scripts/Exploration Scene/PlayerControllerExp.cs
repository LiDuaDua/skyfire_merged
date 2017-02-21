using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControllerExp : MonoBehaviour {
    public float playerSpeed = 5;
    private Animator anim1;
    private Rigidbody2D myrigidbody;
    public int playerSteps = 0;
	public Text breadtext;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Transform> ().position = CharacterPos.pos;
        anim1 = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
		breadtext.text = "Bread: " + Mathf.Ceil (Backpack.bread);
	}
	
	// Update is called once per frame
	void Update () {

		breadtext.text = "Bread: " + Mathf.Floor (Backpack.bread);

        if (needBread()==true)
        {
            SceneManager.LoadScene("Scenes/DarkWorld", LoadSceneMode.Single);
        }

		if (((Input.GetAxisRaw("Horizontal")>0.5f) || (Input.GetAxisRaw("Horizontal") < -0.5f)))
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") *playerSpeed *Time.deltaTime,0f,0f));
            myrigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*playerSpeed, myrigidbody.velocity.y);
            Backpack.bread=Backpack.bread-0.02f;
        }
        if ((Input.GetAxisRaw("Vertical") > 0.5f) || (Input.GetAxisRaw("Vertical") < -0.5f))
        {
            //transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime, 0f));
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, Input.GetAxisRaw("Vertical")*playerSpeed);
            Backpack.bread = Backpack.bread - 0.02f;
        }
        if ((Input.GetAxisRaw("Horizontal") > -0.5f) && (Input.GetAxisRaw("Horizontal") < 0.5f))
        {
            myrigidbody.velocity = new Vector2(0f, myrigidbody.velocity.y);
        } 
        if ((Input.GetAxisRaw("Vertical") < 0.5f) && (Input.GetAxisRaw("Vertical") > -0.5f))
        {
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, 0f);
        } 

            anim1.SetFloat("Movex", Input.GetAxisRaw("Horizontal"));
        anim1.SetFloat("Movey", Input.GetAxisRaw("Vertical"));
    }

    bool needBread()
    {
       if (Backpack.bread<0f)
        {
            return true;
        }
       else
        {
            return false;
        }
    }

    
   
}
