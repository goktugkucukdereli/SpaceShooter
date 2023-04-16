using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TMP_Text bullettext;
    public TMP_Text scoretext;
    public TMP_Text timetext;
    public GameObject pause;

    public static int bulletcount;
    public static int score;
    private float time;

    private int Score;
    private int HighScore;

    void Start()
    {
        HighScore = PlayerPrefs.GetInt("Highscore");

        Debug.Log(HighScore);
    }


    public void Update()
    {
        bullettext.text = "Bullet Count: " + bulletcount;
        scoretext.text = "Score: " + score;
        time += Time.deltaTime;
        timetext.text = "Time: " + time.ToString("F1");

        if (Input.GetKeyDown(KeyCode.P)) 
        {
            Time.timeScale = 0;
            pause.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.O)) 
        {
            Time.timeScale = 1;
            pause.SetActive(false);
        }

        if (Score > HighScore)
        {
            HighScore = Score;
            PlayerPrefs.SetFloat("Highscore", Score);
        }
    }
}
