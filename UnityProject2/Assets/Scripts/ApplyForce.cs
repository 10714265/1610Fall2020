using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyForce : MonoBehaviour
{
    public Rigidbody theBody;
    public float theForce = 30f;

    void start()
    {
        
    }

    private void OnMouseDown()
    {
        theBody.AddForce( 0 , theForce, 0);
    }
}
