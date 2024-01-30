using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pressurePlate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        on.SetActive(false);
        off.SetActive(true);
    }
    public GameObject on;
    public GameObject off;
    //public GameObject gate1;
    //public GameObject gate2;   
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (off.activeInHierarchy)
        {   
            //gate1.SetActive(false); gate2.SetActive(false);
            on.SetActive(true);
            off.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exited");

        if (on.activeInHierarchy)
        {
            //gate1.SetActive(true); gate2.SetActive(true);
            on.SetActive(false);
            off.SetActive(true);
        }

    }
}
