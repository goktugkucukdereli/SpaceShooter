using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipMove : MonoBehaviour
{
    public float enemySpeed;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0f, -transform.position.y * enemySpeed, 0f);
        transform.Rotate(-180f, 0f, 0f);
    }
}
