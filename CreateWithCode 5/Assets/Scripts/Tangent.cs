﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tangent : MonoBehaviour
{
    private Rigidbody targetRb;
    // Start is called before the first frame update
    void Start()
    {
        targetRb = GetComponent<Rigidbody>();
        
        targetRb.AddForce(Vector3.up*Random.Range(12, 16), ForceMode.Impulse);
        targetRb.AddTorque(Random.Range(-10, 10), Random.Range(-10, 10),Random.Range(-10, 10),ForceMode.Impulse);
        
        transform.position = new Vector3(Random.Range(-4,4), -6);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
