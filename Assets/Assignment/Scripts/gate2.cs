using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gate.SetActive(true);
    }
    public GameObject target1;
    public GameObject target2;
    public GameObject target3;
    public GameObject gate;
    // Update is called once per frame
    void Update()
    {
        if(target1.activeInHierarchy && target2.activeInHierarchy && target3.activeInHierarchy)
        {
            gate.SetActive(false);
        }
        else { gate.SetActive(true); 
        }
    }

}
