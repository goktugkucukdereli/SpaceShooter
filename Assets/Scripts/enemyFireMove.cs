using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFireMove : MonoBehaviour
{
    private Rigidbody rb;
    public float rbForce;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * rbForce);
        
    }
    void Update()
    {
        
    }
}
