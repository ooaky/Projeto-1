using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    #region Variables

    public float life = 10f;
    public float damage = 1.5f;

    public bool canAccelerate = false;

    public GameObject myObject;
    public Transform myTransform;

    [Header("Colour")]
    public Color color = Color.blue;

    [Header("Inputs")]  
    public KeyCode keycode = KeyCode.Space;
    #endregion


    public void ChangeColor(Color newColor)
    {
        color = newColor;
        life -= damage;
    }
    void Start()
    {
        
    }

    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space))
        {
            ChangeColor(Color.magenta);
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            ChangeColor(Color.red);
        }
    }
}
