using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource audioSource; //Lägga in för vilken AudioSource & AudioClip det ska vara
    public AudioClip ClickClip;

    public void ClickSoundEffect() 
    { 
        audioSource.Play(); //Talar om Audio Source att spelas upp
        Debug.Log("Play Effect");
    }

    private void Start()
    {
        DontDestroyOnLoad(audioSource);
        Debug.Log("Don't Destroy Click");
    }
}
