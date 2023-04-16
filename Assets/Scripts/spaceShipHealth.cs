using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spaceShipHealth : MonoBehaviour
{
    public GameObject health;
    public GameObject content;
    public GameObject[] allHealth;

    public int shipHealth;
    void Start()
    {
        allHealth = new GameObject[shipHealth];
        for (int i = 0; i < shipHealth; i++) 
        {
            GameObject g = Instantiate(health);
            g.transform.SetParent(content.transform);
            allHealth[i] = g;
        }
            
    }
    private void OnTriggerEnter(Collider other)
    {
        shipHealth--;
        if (shipHealth == 1)
        {
            audioManager.aManager.alarmVoice();
        }

        if (shipHealth > 0) 
        {
            allHealth[shipHealth].SetActive(false);
        }

        else if (shipHealth <= 0)
        {
            allHealth[0].SetActive(false);
            gameObject.SetActive(false);
            Invoke("BackToMenu", 2);
        }

        

        //else if (shipHealth == 1)
        //{
        //    audioManager.aManager.alarmVoice();
        //}

        

    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
