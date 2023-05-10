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
        Invoke("VideoTimer", videoLength);
    }

    public void ContinueStartGame()
    {
        showUpObject.SetActive(true);
        Debug.Log("Nu1l");
    }
}
