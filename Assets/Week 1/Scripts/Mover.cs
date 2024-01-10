using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        float keyboardInput = Input.GetAxis("Horizontal");
        transform.Translate(keyboardInput * speed * Time.deltaTime,0, 0);
    }
}
