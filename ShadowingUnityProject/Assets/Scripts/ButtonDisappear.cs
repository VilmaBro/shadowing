using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonDisappear : MonoBehaviour
{

    public Button ForwardButton;

    // Start is called before the first frame update
    void Start()
    {
        ForwardButton.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    public void OnButtonClick()
    {
        ForwardButton.onClick.RemoveListener(OnButtonClick);

        ForwardButton.gameObject.SetActive(false);
    }



}
