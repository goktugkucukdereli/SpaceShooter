using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamikazeCtrl : MonoBehaviour
{
    public Vector3 kamikazeRandomPos;
    public GameObject kamikaze;
    public float startTime;
    public float createTime;
    void Start()
    {
        InvokeRepeating("kamikazeCreate", startTime, createTime);
    }
    private void kamikazeCreate()
    {
        Vector3 vec = new Vector3(Random.Range(-kamikazeRandomPos.x, kamikazeRandomPos.x), kamikazeRandomPos.y, 9f);
        Instantiate(kamikaze, vec, Quaternion.identity);
    }
}
