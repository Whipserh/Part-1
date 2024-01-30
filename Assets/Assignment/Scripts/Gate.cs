using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject on;
    public GameObject gate;
    // Update is called once per frame
    void Update()
    {
        if (on.activeInHierarchy)
        {
            Debug.Log(on + " is on in hierarchy ");
            gate.SetActive(false);
        }else
        {
            Debug.Log(on + "is not on in hier");
            gate.SetActive(true);
        }
    }

}
