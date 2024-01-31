using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class target2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        off.SetActive(true);
        on.SetActive(false);

    }
    
    public GameObject on;
    public GameObject off;
    private float timehit;
    // Update is called once per frame

    void Update()
    {
        if (on.activeInHierarchy && Time.realtimeSinceStartup - timehit >= 1)
        {
            off.SetActive(true);
            on.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //   Debug.Log("entered");
        if (off.activeInHierarchy)
        {
            timehit = Time.realtimeSinceStartup;
            off.SetActive(false);
            on.SetActive(true);
        }
    }
}
