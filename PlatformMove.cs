
using UnityEngine;

public class PlatformMove : MonoBehaviour {



    public float moveForce = 200f;
   public Rigidbody2D rb;
    public GameObject platformSpawn;
    public GameObject platform;
    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            transform.position = new Vector3(-9, -4, 0);



            rb.velocity = Vector2.right * moveForce * Time.deltaTime;



        }
		
	}
}
