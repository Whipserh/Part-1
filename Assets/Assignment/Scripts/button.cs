using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        unpress.SetActive(true);
        pressed.SetActive(false);

    }
    public Transform spawnPoint;
    public GameObject arrow;
    public GameObject unpress;
    public GameObject pressed;
    private float timehit;
    // Update is called once per frame
    
    void Update()
    {
     if(pressed.activeInHierarchy && Time.realtimeSinceStartup - timehit >= 2)
        {
            unpress.SetActive(true);
            pressed.SetActive(false);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     //   Debug.Log("entered");
        if (unpress.activeInHierarchy)
        {
            timehit = Time.realtimeSinceStartup;
            Instantiate(arrow, spawnPoint.position, spawnPoint.rotation);
            unpress.SetActive(false);
            pressed.SetActive(true);
        }
    }
}
