using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    Rigidbody2D bod;
    // Start is called before the first frame update
    void Start()
    {
        bod = GetComponent<Rigidbody2D>(); 
        barrelDown.SetActive(false);
        barrelUp.SetActive(true);
    }


    public GameObject barrelUp;
    public GameObject barrelDown;
    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (barrelUp.activeInHierarchy)
        {
            barrelUp.SetActive(false);
        }
        barrelDown.SetActive(true);

    }
}
