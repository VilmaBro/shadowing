using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkipForward : MonoBehaviour
{
    public VideoPlayer video;
    public GameObject Button;
    public int time;

    public void OnPointerClick()
    {
        video.time += (time); 
        Debug.Log("Skip");
    }

    
}
