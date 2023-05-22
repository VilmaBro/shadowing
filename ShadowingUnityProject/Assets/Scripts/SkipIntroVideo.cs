
using UnityEngine;
using UnityEngine.SceneManagement;


public class SkipIntroVideo : MonoBehaviour
{

    public float timeBetweenTaps = 0.3f; // the time limit between taps to be considered a double tap
    private float lastTapTime;
    private float timeSceneLevelStart;

    public void Update()
    {
        timeSceneLevelStart += Time.deltaTime;

        if (timeSceneLevelStart > 3f && Input.GetMouseButtonDown(0))
        {

            if (Time.time - lastTapTime < timeBetweenTaps)
            {
                SceneManager.LoadScene(2);
            }
            lastTapTime = Time.time;
        }
    }
}
