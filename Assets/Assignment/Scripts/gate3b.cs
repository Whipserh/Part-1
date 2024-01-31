using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate3b : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gate.SetActive(true);
    }
    public GameObject buttonPressed;
    public GameObject targetHit;
    public GameObject gate;
    // Update is called once per frame
    void Update()
    {
        
        if (buttonPressed.activeInHierarchy)
        {
            
            gate.SetActive(false);
        }else if (targetHit.activeInHierarchy)
        {
            gate.SetActive(true);
        }


    }
}
