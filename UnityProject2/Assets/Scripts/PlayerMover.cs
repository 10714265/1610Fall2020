using System;
using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
    public float xfast;
    public Vector3 xdegree;
    private void Update()
    {

        if (Input.GetButton("Jump"))
        {
            xdegree.x = xfast * Time.deltaTime;
            transform.Translate(xdegree);
        }
        else
        {
            xdegree.x = - xfast * Time.deltaTime;
            transform.Translate(xdegree); 
        }
        
    }
}
