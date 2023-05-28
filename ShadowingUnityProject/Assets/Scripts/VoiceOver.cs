using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VoiceOver : MonoBehaviour
{

    public float delaySeconds = 2f;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartCoroutine(EnableAudioSourceAfterDelay());
    }

    private IEnumerator EnableAudioSourceAfterDelay()
    {
        yield return new WaitForSeconds(delaySeconds);
        audioSource.enabled = true;
        audioSource.Play();
        Debug.Log("VoiceOver");
    }
}

