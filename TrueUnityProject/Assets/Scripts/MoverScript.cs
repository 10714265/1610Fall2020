using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 10f;
    public int count;
    public Vector3 rotationVector3;
    private void Update()
    {
        count++;
        if (count > 100)
        {
            print("Greater");
        }
        
        rotationVector3.y = speed * Time.deltaTime;
        transform.Rotate(rotationVector3);
    }
}

