using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public AudioSource audio;

    public void playClick()
    {
        audio.Play();
        
    }
}
