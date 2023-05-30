using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{
    public AudioSource audioSource; 
    public AudioClip ClickClip;

    public void ClickSoundEffect() 
    { 
        audioSource.Play(); 
        Debug.Log("Play Effect");
    }

    private void Start()
    {
        DontDestroyOnLoad(audioSource);
        Debug.Log("Don't Destroy Click");
    }
}
