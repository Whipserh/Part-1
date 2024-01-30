using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector2(1, 0);
        rigidbody = gameObject.GetComponent<Rigidbody2D>();
    }


    private Rigidbody2D rigidbody;
    private Vector2 direction;
    // Update is called once per frame
    void Update()
    {
        
        
    }
    public float force = 5;
    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

    }
}
