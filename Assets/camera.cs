using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Camera mainCamera;
    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main;
        mainCamera.orthographicSize = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        WrapAroundScreen();
    }
    void WrapAroundScreen()
    {
        Vector3 position = transform.position;
        Vector3 viewportPosition = mainCamera.WorldToViewportPoint(position);

        if (viewportPosition.x < 0)
        {
            viewportPosition.x = 1;
        }
        else if (viewportPosition.x > 1)
        {
            viewportPosition.x = 0;
        }

        if (viewportPosition.y < 0)
        {
            viewportPosition.y = 1;
        }
        else if (viewportPosition.y > 1)
        {
            viewportPosition.y = 0;
        }

        transform.position = mainCamera.ViewportToWorldPoint(viewportPosition);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bullet"))
        {
            FindObjectOfType<asteroidDestruction>().AsteroidDestroyed();
            Destroy(gameObject); // Destroy the asteroid
        }
    }

}
