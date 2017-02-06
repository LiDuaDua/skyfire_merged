using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerExp : MonoBehaviour {
    public float playerSpeed;
    private Animator anim1;
    private Rigidbody2D myrigidbody;

	// Use this for initialization
	void Start () {
        anim1 = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

		if ((Input.GetAxisRaw("Horizontal")>0.5f) || (Input.GetAxisRaw("Horizontal") < -0.5f))
        {
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") *playerSpeed *Time.deltaTime,0f,0f));
            myrigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*playerSpeed, myrigidbody.velocity.y);
        }
        if ((Input.GetAxisRaw("Vertical") > 0.5f) || (Input.GetAxisRaw("Vertical") < -0.5f))
        {
            //transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime, 0f));
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, Input.GetAxisRaw("Vertical")*playerSpeed);
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
   
}
