using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float acceleration;
    Rigidbody2D rigidbod;
    float steering;
    float accelerate;
    public float forwardspeed = 300;
    public float steeringSpeed = 50;
    // Start is called before the first frame update
    void Start()
    {
        rigidbod = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        accelerate = Input.GetAxis("Vertical");
        if (accelerate != 0)
        {
            steering = Input.GetAxis("Horizontal");
        }
        else { steering = 0; }
    }

    private void FixedUpdate()
    {
        if (steering != 0)
        {
            rigidbod.AddTorque(steering * -steeringSpeed * Time.deltaTime);

        }
        Vector2 force = transform.up * accelerate * forwardspeed * Time.deltaTime;
        rigidbod.AddForce(force);
    }
}
