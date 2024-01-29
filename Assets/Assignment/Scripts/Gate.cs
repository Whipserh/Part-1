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

    // Update is called once per frame
    void Update()
    {
        if (on.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }else
        {
            gameObject.SetActive(true);
        }
    }

}
