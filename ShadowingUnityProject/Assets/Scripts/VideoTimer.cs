using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoTimer : MonoBehaviour
{

    public GameObject showUpObject;
    public float videoLength;

    void Start()
    {
        Invoke("changeToNextScene", videoLength);
    }

    public void changeToNextScene()
    {
        showUpObject.SetActive(true);
        
    }
}
