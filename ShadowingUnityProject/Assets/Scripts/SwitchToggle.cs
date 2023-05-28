using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
    [SerializeField] RectTransform uiHandleRectTransform;
    [SerializeField] Color backgroundActiveColor;

    Image backgroundImage, handleImage;

    Color backgroundDefaultColor, handleDefaultColor;

    Toggle toggle;

    Vector2 handlePosition;

    void Awake()
    {
        //Referera till
        toggle = GetComponent<Toggle>(); 

        handlePosition = uiHandleRectTransform.anchoredPosition;

        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>(); 

        backgroundDefaultColor = backgroundImage.color;

        //Lägger till Listener i händelsen onValueChanged, som  styrs av OnSwitch

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }

    void OnSwitch(bool on) //OnSwitch metod
    {
        uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition; //Byter positionen om den är på(on)
        backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor; //Byter färg när den är på (on)

    }
}
