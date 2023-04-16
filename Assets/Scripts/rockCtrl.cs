using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockCtrl : MonoBehaviour
{
    public Vector3 rockRandomPos;
    public GameObject rock;
    public float startTime;
    public float createTime;
    void Start()
    {
        InvokeRepeating("rockCreate", startTime, createTime);
    }
    private void rockCreate()
    {
        Vector3 vec = new Vector3(Random.Range(-rockRandomPos.x, rockRandomPos.x), rockRandomPos.y, 9f);
        Instantiate(rock, vec, Quaternion.identity);
    }
}
