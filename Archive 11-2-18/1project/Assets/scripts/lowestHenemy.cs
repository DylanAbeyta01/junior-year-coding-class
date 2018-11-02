using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lowestHenemy : MonoBehaviour
{
    public float min = 2f;
    public float max = 3f;
    float speed = 5;
    Vector3 velocity = new Vector3(0, 0, 0);

    // Use this for initialization
    void Start ()
    {
        min = transform.position.x;
        max = transform.position.x + 15;
    }

    // Update is called once per frame
    void Update ()
    {
        transform.position = new Vector3(Mathf.PingPong(Time.time * 6, max - min) + min, transform.position.y, transform.position.z);

    }
}
