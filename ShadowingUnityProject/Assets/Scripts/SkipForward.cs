using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class SkipForward : MonoBehaviour
{
    public float timeBetweenTaps = 0.3f; //the timelimit between taps to be considered a double tap
    private float lastTapTime;
    private float StartNewClip;
    public VideoPlayer video;


    public void Update()
    {
        StartNewClip += Time.deltaTime;

        if (StartNewClip > 3f && Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastTapTime < timeBetweenTaps)
            {
                video.time += 15.0f;
                print("Forward Clip");
            }

            lastTapTime = Time.time;
        }
    }
}
