using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisappear : MonoBehaviour
{
    public Button Disappear;

    // Start is called before the first frame update
    void Start()
    {
        Disappear.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        Disappear.onClick.RemoveListener(OnButtonClick);

        Disappear.gameObject.SetActive(false);
    }
}
