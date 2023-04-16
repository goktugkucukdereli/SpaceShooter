using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    public static audioManager aManager;
    public AudioClip[] voices;
    AudioSource aSource;

    void Awake()
    {
        aSource = GetComponent<AudioSource>();

        // singleton
        if (aManager == null)
            aManager = this;
        else if (aManager != null)
            Destroy(gameObject);
    }

    void Update()
    {
        
    }

    public void fireVoice() 
    {
        aSource.PlayOneShot(voices[0]);
    }

    public void expVoice()
    {
        aSource.PlayOneShot(voices[1]);
    }

    public void alarmVoice()
    {
        aSource.PlayOneShot(voices[2]);
    }
}
