using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject projectile;
    public Transform shootPoint;
    public Vector3 dir;
    public PoolManager PoolManager;
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(dir * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-dir * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            SpawnObject();
        }

        /*if (Input.GetMouseButton(0))
        {
            SpawnObject();
        }*/

    }

    public void SpawnObject()
    {
        var obj = PoolManager.GetPooledObject();
        obj.SetActive(true);
        obj.GetComponent<Projectile>().StartProjectile();
        //obj.transform.SetParent(null);
        obj.transform.position = shootPoint.transform.position;
    }
}
