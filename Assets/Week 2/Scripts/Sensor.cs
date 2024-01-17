using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{

    public SpriteRenderer spriteRend;


    // Start is called before the first frame update
    void Start()
    {
        spriteRend.color = Color.green;
    }

    //we go inside the circle we change the color to red
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + " is in the trigger");
        spriteRend.color = Color.red;
    }


    //we leave the circle so we change back to green
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject + " has left the building");
        spriteRend.color = Color.green;
    }















    // Update is called once per frame
    void Update()
    {
        
    }

}
