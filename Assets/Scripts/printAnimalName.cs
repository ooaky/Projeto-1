using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Animals
{
    Dolphin,
    Shark,
    Whale
}


public class printAnimalName : MonoBehaviour
{
    public List<AnimalSetup> animalSetup;


    public bool checkStatus = false;

    [Range(-5, 5)]
    public int value01;
    public int value02;

    public int checkOne = 0;

    private void CheckSwitchCase(Animals a)
    {
        switch (a)
        {
            case Animals.Dolphin:
                OnReadDolphin();
                break;
            case Animals.Shark:
                OnReadShark();
                break;
            case Animals.Whale:
                OnReadWhale();
                break;
            default:
                Debug.Log("Default");
                break;
        }
    }


    private void ShowTextByAnimal(Animals a)
    {
        foreach (var animal in animalSetup)
        {
            if (animal.animalType == a)
                Debug.Log(animal.text);
        }
    }

    private void CheckKeys()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            //CheckSwitchCase(Animals.Dolphin);
            ShowTextByAnimal(Animals.Dolphin);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            //CheckSwitchCase(Animals.Shark);
            ShowTextByAnimal(Animals.Shark);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            //CheckSwitchCase(Animals.Whale);
            ShowTextByAnimal(Animals.Whale);
        }
    }

    private void CheckValues()
    {
        //if(true E true) 
        if (value01 == checkOne)
        {
        }
        else if (value01 == 0)
        {
        }
        else if (value01 == 2)
        {
        }
    }

    #region Read Animals
    private void OnReadDolphin()
    {
        /*
        foreach (var animal in animalSetup)
        {
            if (animal.animalType == Animals.Dolphin)
                Debug.Log(animal.text);
        }*/
    }

    private void OnReadShark()
    {
        /*
        foreach (var animal in animalSetup)
        {
            if (animal.animalType == Animals.Shark)
                Debug.Log(animal.text);
        }*/
    }

    private void OnReadWhale()
    {
        /*
        foreach (var animal in animalSetup)
        {
            if (animal.animalType == Animals.Whale)
                Debug.Log(animal.text);
        }*/
    }
    #endregion

    private void Update()
    {
        //CheckSwitchCase();
        CheckKeys();
        //CheckValues();



        #region For
        /*
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("i ->" + i);
        }*/

        /*
        for (int i = 3; i >= 0; i--)
        {
            Debug.Log("i ->" + i);
        }*/


        /*
        foreach (var animal in animalSetup)
        {
            Debug.Log(animal.animalType + " :: " + animal.text);
        }*/
        #endregion

    }

}


[System.Serializable]

public class AnimalSetup
{
    public Animals animalType;
    public string text;
}