using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoting : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPref, bulletPref2;
    public bool shgun=false;

    public float bulletForce=20f;

    public GameObject sold;
    injsoldier inj;
    private void Start()
    {
        inj = sold.GetComponent<injsoldier>();
        
        shgun = false;
    }
    void FixedUpdate()
    {
        if (inj.skor > 30)
        {
            shgun = true;
        }
        
        if (shgun==true)
        {
            if (Input.GetButton("Fire1"))
            {
                Gunshoot();
            }
        }
        else
        {
            if (Input.GetButton("Fire1"))
            {
                Normalshoot();
            }           
        }
    }
    void Normalshoot()
    {
        GameObject bullet = Instantiate(bulletPref, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce,ForceMode2D.Impulse);
    }
    void Gunshoot()
    {
        GameObject bullet = Instantiate(bulletPref2, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);
    }
}


