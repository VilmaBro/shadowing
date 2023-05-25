using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class SkipForward : MonoBehaviour
{
    public float timeBetweenTaps = 0.3f; //the timelimit between taps to be considered a double tap
    private float lastTapTime;
    private float Forward;
    public VideoPlayer video;
    public int time;

    void Update()
    {
        Forward += Time.deltaTime;

        if (Forward > 3f && Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastTapTime < timeBetweenTaps)
            {
                video.time += (time);
                Debug.Log("Skip");
            }

            lastTapTime = Time.time;
        }
    }

}
