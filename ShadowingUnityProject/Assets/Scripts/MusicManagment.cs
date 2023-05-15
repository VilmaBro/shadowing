using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManagment : MonoBehaviour
{
    [SerializeField] AudioSource AudioSource;
    [SerializeField] AudioClip MusicClip;

    private void Start()
    {
        AudioSource.clip = MusicClip;
        AudioSource.loop = true;
        AudioSource.Play();
    }

    public static MusicManagment instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(transform.root);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
