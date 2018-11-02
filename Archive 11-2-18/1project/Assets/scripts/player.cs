using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
   float speed = 5;

    Vector3 velocity = new Vector3(0, 0, 0);
    Rigidbody2D rbody;

    // Use this for initialization
    void Start ()
    {
        rbody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update ()
    {
       
        velocity = rbody.velocity;
        if (Input.GetKey(KeyCode.W))
        {
            velocity += Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity -= Vector3.up * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity -= Vector3.right * Time.deltaTime * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity += Vector3.right * Time.deltaTime * speed;
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && !Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            velocity = new Vector3(velocity.x * (1 - Time.deltaTime * 10), velocity.y * (1 - Time.deltaTime * 10), 0);
        }
        rbody.velocity = new Vector3(Mathf.Clamp(velocity.x, -speed, speed), Mathf.Clamp(velocity.y, -speed, speed), 0);


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (Application.loadedLevelName == "LEVEL1" && collision.collider.tag == "bad")
        {
            Application.LoadLevel("LEVEL1"); //name of your death scene
        }
        if (collision.collider.tag == "winnner")
        {
            Application.LoadLevel("LEVEL2"); //name of winner scene
        }
        if (Application.loadedLevelName == "LEVEL2" && collision.collider.tag == "bad")
        {
            Application.LoadLevel("LEVEL2");
        }
    }
}
