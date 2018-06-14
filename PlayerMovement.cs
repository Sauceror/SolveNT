using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float jumpForce = 10f;
    public float movement = 500f;
    public Rigidbody2D rb;
    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            rb.velocity = Vector2.up * jumpForce;



        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.velocity = Vector2.left * movement * Time.deltaTime;



        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = Vector2.right * movement * Time.deltaTime;



        }


    }
}
