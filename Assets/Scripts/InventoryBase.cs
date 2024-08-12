using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryBase : MonoBehaviour
{
    public List<GameObject> myObjects;
    public float delayBetweenObjects = .1f;

    private bool _isShowing = false;

    private void Awake()
    {
        Hide();
    }
    private void Hide()
    {
        _isShowing = false;
        foreach (GameObject g in myObjects)
        {
            g.SetActive(false);
        }
    }
    public void ShowItens()
    {
        if (_isShowing)
        {
            Hide();
        }
        else
        {
            _isShowing = true;
            StartCoroutine(Show());

        }

    }

    IEnumerator Show()
    {
        foreach (GameObject g in myObjects)
        {
            yield return new WaitForSeconds(delayBetweenObjects);
            g.SetActive(true);
        }
    }
}
