using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public float speed = 5f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime, 0, 0);
    }
}
