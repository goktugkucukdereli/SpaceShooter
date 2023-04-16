using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockMove : MonoBehaviour
{
    public float asteroidSpeed;
    Rigidbody rb;
    public float angularSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, -transform.position.y * asteroidSpeed, 0f);
        rb.angularVelocity = Random.insideUnitSphere * angularSpeed;
    }
}
