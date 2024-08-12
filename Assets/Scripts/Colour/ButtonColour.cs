using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonColour : MonoBehaviour
{
    public Color wantedColor;
    public Button button;


    void Start()
    {

    }


    void Update()
    {

    }

    public void ChangeButtonColor()
    {
        ColorBlock cb = button.colors;
        cb.normalColor = wantedColor;
        cb.highlightedColor = wantedColor;
        cb.pressedColor = wantedColor;
        button.colors = cb;
    }
}
