using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject hiteff;

    
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        
    }
    IEnumerator ExampleCoroutine()
    { 
        yield return new WaitForSeconds(1);
        Destroy(gameObject);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hiteff, transform.position, Quaternion.identity);
        Destroy(effect, .3f);
        Destroy(gameObject);
    }

}
