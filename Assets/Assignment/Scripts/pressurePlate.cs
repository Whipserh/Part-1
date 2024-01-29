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
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollision2DEnter()
    {
        Debug.Log("entered");
        if (off.activeInHierarchy)
        {   
            
            on.SetActive(true);
            off.SetActive(false);
        }
    }

    private void OnCollision2DExit()
    {
        Debug.Log("Exited");

        if (on.activeInHierarchy)
        {
            on.SetActive(false);
            off.SetActive(true);
        }

    }
}
