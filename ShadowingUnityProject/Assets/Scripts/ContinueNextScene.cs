using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueNextScene : MonoBehaviour
{
    public GameObject continueButton;
    public float videoLength;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Continue", videoLength);

    }

    public void Continue()
    {
        continueButton.SetActive(true);
        Debug.Log("NU");
    }
}

