using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowTrap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject buttonPressed;
    public GameObject arrowPrefab;
    // Update is called once per frame
    void Update()
    {
        if (buttonPressed.activeInHierarchy)
        {
           // Intsantate(arrowPrefab, );
        }
    }
}
