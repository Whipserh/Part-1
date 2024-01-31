using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gate3a : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject plate1;
    public GameObject plate2;
    public GameObject gate;
    // Update is called once per frame
    void Update()
    {
        if (plate1.activeInHierarchy && plate2.activeInHierarchy)
        {
            gate.SetActive(false);
        }
        else
        {
            gate.SetActive(true);
        }
    }
}
