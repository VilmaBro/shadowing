using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDisappear : MonoBehaviour
{

    [SerializeField] GameObject DisappearButton;

    IEnumerator Start()
    {
        DisappearButton.SetActive(true);
        yield return new WaitForSeconds(8.0f);
        DisappearButton.SetActive(false);
    }
}
