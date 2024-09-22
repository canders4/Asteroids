using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float thrust = 1.0f;
    public float rotation = 1.0f;
    private Rigidbody2D Triangle;
    // Start is called before the first frame update
    void Start()
    {
        Triangle = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Triangle.AddForce(transform.up * thrust);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            Triangle.AddForce(-transform.up * thrust); 
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Triangle.AddTorque(rotation);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Triangle.AddTorque(-rotation);
        }
    }
}
