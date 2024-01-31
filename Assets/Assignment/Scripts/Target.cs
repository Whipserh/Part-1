using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        off.SetActive(true);
        on.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public GameObject on;
    public GameObject off;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (on.activeInHierarchy)
        {
            on.SetActive(false);
            off.SetActive(true);
        }else
        {
            on.SetActive(true);
            off.SetActive(false);
        }
    }
}
