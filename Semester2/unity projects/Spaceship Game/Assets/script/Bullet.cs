using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float timer = 0;
    float timeToAction = 5;
    public Vector3 velocity = new Vector3(0, 0, 0);
    public GameObject BulletPrefab;
    float speed = 3f;
    // Use this for initialization
    void Start ()
    {
        timer += Time.deltaTime;

        if (timer >= timeToAction)
        {
            DestroyImmediate(gameObject);
            timer = 0;
        }
    }
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void Initialize(Vector3 position, Vector3 velocity, Color color)
    {
        this.transform.position = position;
        this.velocity = velocity;
        GetComponent<SpriteRenderer>().color = color;
        GetComponent<Rigidbody2D>().velocity = velocity * speed;
    }
}
