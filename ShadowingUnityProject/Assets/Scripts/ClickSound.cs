using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickSound : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip ClickClip;

    public void ClickSoundEffect()
    {
        print("Play Effect");
        audioSource.Play();
    }
}
