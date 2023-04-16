using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyFire : MonoBehaviour
{
    public Vector3 fireRandomPos;
    public GameObject enemybullet;
    public GameObject enemyBulletPoint;
    public float startTime;
    public float createTime;

    void Start()
    {
        
        InvokeRepeating("fireCreate", startTime, createTime);
    }
    void Update()
    {
        //Instantiate(enemybullet, enemyBulletPoint.transform.position, Quaternion.Euler(0, 0, 0)); //transform.rotation);
        
    }
    private void fireCreate()
    {
        Instantiate(enemybullet, enemyBulletPoint.transform.position, Quaternion.Euler(0, 0, 0)); //transform.rotation);
    }
}
