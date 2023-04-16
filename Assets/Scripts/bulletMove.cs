using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    private Rigidbody rb;
    public float rbForce;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.up * rbForce);
    }
    private void dstry()
    {
        if (transform.position.y > 60f)
        {
            Destroy(gameObject);
        }
    }
    void Update()
    {
        dstry();
    }
}
