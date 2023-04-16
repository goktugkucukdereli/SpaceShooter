using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletCtrl : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletpos;
    void Update()
    {
        fire();
    }
    private void fire()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletpos.transform.position, transform.rotation);
            UIManager.bulletcount++;
            audioManager.aManager.fireVoice();
        }
    }
}
