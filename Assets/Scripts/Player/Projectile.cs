using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float timeToReset = 2f;
    public Vector3 dir;
    void Update()
    {
        transform.Translate(dir * Time.deltaTime);
    }

    public void StartProjectile()
    {
        Invoke(nameof(FinishUsage), timeToReset);
    }

    private void FinishUsage()
    {
        gameObject.SetActive(false);
    }
}
