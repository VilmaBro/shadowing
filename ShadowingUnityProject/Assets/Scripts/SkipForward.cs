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
        video.time += (time); //Video tiden ska plusas på med tiden som skrivs in
        Debug.Log("Skip");
    }

    
}
