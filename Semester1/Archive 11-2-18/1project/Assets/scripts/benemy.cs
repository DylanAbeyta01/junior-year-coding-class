using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class benemy : MonoBehaviour
{

	public float min = 2f;
    public float max = 3f;
    float speed = 5;
    Vector3 velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start()
    {
        min = transform.position.y;
        max = transform.position.y + 3.2f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 4, max - min) + min, transform.position.z);
    }
}
