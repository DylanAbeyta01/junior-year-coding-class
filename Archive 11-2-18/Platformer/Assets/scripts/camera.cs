using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public GameObject character;
    Vector3 goalVector = new Vector3();
    float hSpeed = 2f;
    float vSpeed = 1.2f;

	// Use this for initialization
	void Start ()
    {
        transform.position = new Vector3(character.transform.position.x, character.transform.position.y, -10);
	}
	
	// Update is called once per frame
	void Update ()
    {
        goalVector =  new Vector3(character.transform.position.x, character.transform.position.y, -10);
        goalVector += new Vector3(character.GetComponent<Rigidbody2D>().velocity.x,
            character.GetComponent<Rigidbody2D>().velocity.y, 0);

        Vector3 velocity = goalVector - transform.position;

        transform.position += new Vector3(velocity.x * Time.deltaTime * hSpeed,
            velocity.y * Time.deltaTime * vSpeed, 0);
    }
}
