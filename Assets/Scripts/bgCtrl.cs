using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgCtrl : MonoBehaviour
{
    public float altLimit;
    public float ustLimit;
    public GameObject[] Bg;
    public float Speed;
    void Start()
    {
        
    }


    void Update()
    {
        for(int i = 0; i < Bg.Length; i++)
        {
            Bg[i].transform.Translate(0f, Speed * Time.deltaTime, 0f, Space.World);
            if (Bg[i].transform.position.y < altLimit)
                Bg[i].transform.position = new Vector3(Bg[i].transform.position.x, ustLimit, Bg[i].transform.position.z);
        }
    }
}
