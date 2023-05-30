using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagment : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip MusicClip;

    public static MusicManagment instance;

    private void Awake()
    {
        if(instance == null) 
        {
            instance = this; 
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject); 
        }
    }


    private void Start()
    {
        AudioSource.clip = MusicClip; 
        AudioSource.loop = true; 
        AudioSource.Play();
        DontDestroyOnLoad(AudioSource);
        Debug.Log("Don't Destroy Click");
    }
    
}
