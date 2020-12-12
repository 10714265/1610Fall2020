using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObject : MonoBehaviour
{
    public float rotateValue;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            rotateValue = 60;
        }
        else
        {
            rotateValue = 0;
        }
        
        
        transform.rotation = Quaternion.Euler(0, 0, rotateValue);
    }
}
