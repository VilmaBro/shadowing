using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPopUp : MonoBehaviour
{
    public GameObject showUpObject;
    public GameObject showUpText;
    public float videoLength;

    void Start()
    {
        Invoke("changeToNextScene", videoLength);
    }

    public void changeToNextScene()
    {
        showUpObject.SetActive(true);
        showUpText.SetActive(true);
    }
}
