using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikazeMove : MonoBehaviour
{
    public GameObject spaceShip;
    public float kamikazeSpeed;
    void Start()
    {
        spaceShip = GameObject.FindGameObjectWithTag("Player");
    }
    private void Update()
    {
        
        if(spaceShip != null)
        {
            Vector3 distance = spaceShip.transform.position - transform.position;
            transform.position += distance.normalized * Time.deltaTime * kamikazeSpeed;
            transform.rotation = Quaternion.LookRotation(distance);
        }

        else 
        {
            transform.Translate(0f, -kamikazeSpeed * Time.deltaTime, 0f, Space.World);
            transform.eulerAngles = Vector3.zero;
        }
    }
}
