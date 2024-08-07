using System.Collections;
using System.Collections.Generic;
using Unity.Services.Core;
using UnityEngine;

public class Square : MonoBehaviour
{

    public int door = 2;
    public Color color = Color.yellow;


    private void Awake()
    {
        Init();
    }

    public void Init()
    {
        SquareBase mySquare = new SquareBase(4, Color.blue);
    }
}

public class SquareBase
{
    public int sides = 6;
    public Color color = Color.yellow;

    public SquareBase()
    {
        Debug.Log("Construtor");
    }

    public SquareBase(int sides)
    {
        this.sides = sides;
    }


    public SquareBase(int sides, Color color)
    {
        this.sides = sides;
        this.color = color;
    }
}