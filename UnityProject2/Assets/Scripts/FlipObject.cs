using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipObject : MonoBehaviour
{
    public float rotateValue;
    
    private void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow & KeyCode.UpArrow) || Input.GetKey(KeyCode.A))
        {
            rotateValue = -60;
        }
        
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rotateValue = +60;
        }
        transform.rotation = Quaternion.Euler(0, rotateValue, 0);
    }
}
