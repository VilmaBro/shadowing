using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour
{
    public AudioClip voiceoverClip; // Ljudklippet för voiceover
    public float delayInSeconds; // Antal sekunder innan voiceovern aktiveras

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("PlayVoiceover", delayInSeconds);
    }

    void PlayVoiceover()
    {
        audioSource.clip = voiceoverClip;
        audioSource.Play();
    }
}

