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
        toggle = GetComponent<Toggle>();

        handlePosition = uiHandleRectTransform.anchoredPosition;

        backgroundImage = uiHandleRectTransform.parent.GetComponent<Image>();

        backgroundDefaultColor = backgroundImage.color;

        toggle.onValueChanged.AddListener(OnSwitch);

        if (toggle.isOn)
            OnSwitch(true);
    }

    void OnSwitch(bool on)
    {
        uiHandleRectTransform.anchoredPosition = on ? handlePosition * -1 : handlePosition;
        backgroundImage.color = on ? backgroundActiveColor : backgroundDefaultColor;

    }

    private void OnDestroy()
    {
        toggle.onValueChanged.RemoveListener(OnSwitch);

    }
}
