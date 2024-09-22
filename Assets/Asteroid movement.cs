using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    public float minSpeed = 1.0f;
    public float maxSpeed = 3.0f;
    private Rigidbody2D asteroid;
    // Start is called before the first frame update
    void Start()
    {
        asteroid = GetComponent<Rigidbody2D>();
        asteroid.velocity = Random.insideUnitCircle * Random.Range(minSpeed, maxSpeed);
}

    // Update is called once per frame
    void Update()
    {
        
    }
}
