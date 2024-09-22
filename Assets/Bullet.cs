using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            // Notify the AsteroidManager to respawn the asteroid
            FindObjectOfType<asteroidDestruction>().AsteroidDestroyed();

            // Destroy the asteroid
            Destroy(collision.gameObject);

            // Destroy the bullet
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
