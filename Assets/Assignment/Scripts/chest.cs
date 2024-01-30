using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        closed.SetActive(true);
        open.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public GameObject open;
    public GameObject closed;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (closed.activeInHierarchy)
        {
            closed.SetActive(false);
            open.SetActive(true);
        }

    }

}
