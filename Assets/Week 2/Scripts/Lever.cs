using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        onSwitch = true;
    }
    private Boolean onSwitch;
    public GameObject door;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (onSwitch)
        {
            door.SetActive(false);
            onSwitch=false;
        }
        else
        {
            door.SetActive(true);
            onSwitch = true;
        }
        
    }
}

