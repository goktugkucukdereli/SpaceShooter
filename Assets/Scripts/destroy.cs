using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy : MonoBehaviour
{
    private int Score;
    private int HighScore;

    GameObject gameManager;
    public GameObject explosionFx;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("enemyship"))
        {
            UIManager.score += 100;
        }

        if (other.gameObject.CompareTag("rock"))
        {
            UIManager.score += 50;
        }

        if (other.gameObject.CompareTag("kamikaze"))
        {
            UIManager.score += 200;
        }
        Destroy(other.gameObject);
        Destroy(gameObject);
        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetInt("save", HighScore);
        }
        audioManager.aManager.expVoice();
        GameObject FX = Instantiate(explosionFx, other.transform.position, Quaternion.identity);
        Destroy(FX, 2f);
    }

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("gamemanager");
        HighScore = PlayerPrefs.GetInt("save");
        Debug.Log("High Score: " + HighScore);
    }
}
