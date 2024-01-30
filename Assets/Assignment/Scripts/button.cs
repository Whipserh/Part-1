using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        unpress.SetActive(false);
        pressed.SetActive(true);
    }
    public GameObject unpress;
    public GameObject pressed;
    private float timehit;
    // Update is called once per frame
    void Update()
    {
     if(pressed.activeInHierarchy && Time.deltaTime - timehit == 2)
        {
            unpress.SetActive(false);
            pressed.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("entered");
        if (pressed.activeInHierarchy)
        {
            timehit = (float)Time.deltaTime;
            //gate1.SetActive(false); gate2.SetActive(false);
            unpress.SetActive(true);
            pressed.SetActive(false);
        }
    }
}
