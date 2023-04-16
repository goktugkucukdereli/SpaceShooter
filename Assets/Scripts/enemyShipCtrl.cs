using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShipCtrl : MonoBehaviour
{
    public Vector3 enemyShipRandomPos;
    public GameObject enemyShip;
    public float startTime;
    public float createTime;
    void Start()
    {
        InvokeRepeating("enemyShipCreate", startTime, createTime);
    }
    private void enemyShipCreate()
    {
        Vector3 vec = new Vector3(Random.Range(-enemyShipRandomPos.x, enemyShipRandomPos.x), enemyShipRandomPos.y, 9f);
        Instantiate(enemyShip, vec, Quaternion.identity);
    }
}
