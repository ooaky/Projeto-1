using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SphereAnimation : MonoBehaviour
{
    public float duration = 4;
    public Ease ease = Ease.Linear;

    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveX(-33, duration).SetEase(ease);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
