using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisappear : MonoBehaviour
{

    public GameObject DisappearButton;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(HideAndShow(8.0f));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HideAndShow(float delay)
    {
        DisappearButton.SetActive(true);
        yield return new WaitForSeconds(delay);
        DisappearButton.SetActive(false);
    }
}
