using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    //public Joystick joystick;

    Vector2 movement;
    Vector2 mousePos;

    private void Start()
    {
        Shoting shotgun = gameObject.GetComponent<Shoting>();
    }
    public Camera cam;
    void Update()
    {
        //movement.x= joystick.Horizontal;
        // movement.y = joystick.Vertical; 

        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
    }
    
    void FixedUpdate()
    {
        //rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        Vector2 lookDir = mousePos - rb.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x)* Mathf.Rad2Deg - 90f;
        rb.rotation = angle;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Shoting shotgun = gameObject.GetComponent<Shoting>();
        if (other.tag == "Shotgun")
        {
            shotgun.shgun = true;
        }
    }

}
