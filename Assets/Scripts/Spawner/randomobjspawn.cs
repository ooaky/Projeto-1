using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class randomobjspawn : MonoBehaviour
{
    public GameObject[] myObjects;
    public float timeToDestroy = 3f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-100, 100), 20, Random.Range(-100, 100));
            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        }
    }

    public void Awake()
    {
        Destroy(gameObject, timeToDestroy);
    }

}
