using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menuManager : MonoBehaviour
{
    public GameObject Cam2;
    public Slider VolumeSlider;
    public AudioSource VolumeAudio;
    public GameObject PlayPaneli;
    public GameObject OptionsPaneli;
    public GameObject ExitPaneli;

    //private int Score;
    //private int HighScore;

    public Text scoreText;
    public Text highscoreText;



    private void Start()
    {
        //HighScore = PlayerPrefs.GetInt("Highscore");

        //Debug.Log(HighScore);
    }

    private void Update()
    {
        Cam2.transform.root.transform.Rotate(0f, 45f * Time.deltaTime, 0f, Space.World);
        //scoreText.text = Score.ToString();
        //highscoreText.text = HighScore.ToString();

        //if(Score > HighScore)
        //{
        //    HighScore = Score;
        //    PlayerPrefs.SetFloat("Highscore", Score);
        //}
    }
    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void Vol()
    {
        VolumeAudio.volume = VolumeSlider.value;
    }

    public void GoButton()
    {
        SceneManager.LoadScene(1);
    }

    public void PlayPaneliFonksiyonu()
    {
        PlayPaneli.SetActive(true);
        OptionsPaneli.SetActive(false);
        ExitPaneli.SetActive(false);
    }
    public void OptionsPaneliFonksiyonu()
    {
        PlayPaneli.SetActive(false);
        OptionsPaneli.SetActive(true);
        ExitPaneli.SetActive(false);
    }
    public void ExitPaneliFonksiyonu()
    {
        PlayPaneli.SetActive(false);
        OptionsPaneli.SetActive(false);
        ExitPaneli.SetActive(true);
    }

    public void YesButton()
    {
        Application.Quit();
    }

    public void NoButton()
    {
        PlayPaneli.SetActive(true);
        OptionsPaneli.SetActive(false);
        ExitPaneli.SetActive(false);
    }
}
