
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipIntroVideo : MonoBehaviour
{

    public float timeBetweenTaps = 0.3f; // the time limit between taps to be considered a double tap
    private float lastTapTime;

    void Update()
    {
        // Check if a double tap has occurred
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - lastTapTime < timeBetweenTaps)
            {
                // A double tap has occurred, change the scene
                SceneManager.LoadScene(2);
            }
            lastTapTime = Time.time;
        }
    }
}