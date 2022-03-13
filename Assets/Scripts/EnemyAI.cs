using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyAI : MonoBehaviour
{
    public float hiz;
    Vector2 poz;
    public Transform Target;
    public GameObject Die,butt,skor;
    public int health=20;
    bool isPaused = false;
  
    void Awake()
    {
        Target = GameObject.Find("TargetUpDown").transform;
        butt = GameObject.Find("RetButton");
        skor = GameObject.Find("injsoldierfriend");


    }
    void FixedUpdate()
    {
        poz = new Vector2(Target.position.x, transform.position.y);        
        transform.position = Vector2.MoveTowards(transform.position, Target.position, hiz * Time.fixedDeltaTime);           
        
    }
    void OnTriggerEnter2D(Collider2D other)
   {       
       if (other.tag == "TargetPoint")
       {
            butt.GetComponent<Image>().enabled=true;
            butt.GetComponentInChildren<Text>().enabled=true;
            pauseGame();
       }
   }
   
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag=="Boss")
        {
            health--;
            if(health <= 0)
            {
                GameObject effect = Instantiate(Die, transform.position, Quaternion.identity);
                Destroy(effect, .4f);
                Destroy(gameObject);
            }

        }
        else
        {
            GameObject effect = Instantiate(Die, transform.position, Quaternion.identity);
            Destroy(effect, .4f);
            Destroy(gameObject);
        }
        

    }
    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
            skor.SetActive(false);

        }
    }
}
