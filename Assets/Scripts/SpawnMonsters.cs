using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonsters : MonoBehaviour
{
    public GameObject Tree,Boy,octob;   
    void Start()
    {
        InvokeRepeating("SpawnObject", 3, 2);
        InvokeRepeating("SpawnObject2", 2, 2);
        InvokeRepeating("SpawnObject3", 7, 5);
    }

    void SpawnObject()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        GameObject effect = Instantiate(Tree, transform.position, Quaternion.identity);
    }
    void SpawnObject2()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        GameObject effect = Instantiate(Boy, transform.position, Quaternion.identity);
    }
    void SpawnObject3()
    {
        float x = Random.Range(-2.0f, 2.0f);
        float z = Random.Range(-2.0f, 2.0f);
        GameObject effect = Instantiate(octob, transform.position, Quaternion.identity);
    }



}
