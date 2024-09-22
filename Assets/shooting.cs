using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform circle; 
    public float bulletSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Shoot();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, circle.position, circle.rotation);
        bullet.tag = "Bullet"; 

        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(circle.up * bulletSpeed, ForceMode2D.Impulse);
    }
}
