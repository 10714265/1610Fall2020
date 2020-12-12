using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewMove1 : MonoBehaviour
{
    private Rigidbody rigbod;
    public float jumpforce = 10;
    public float gravity;
    public bool isonground = true;
    
    // Start is called before the first frame update
    void Start()
    {
        rigbod = GetComponent<Rigidbody>();
        Physics.gravity *= gravity;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isonground)
        {
            rigbod.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
            isonground = false;
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        isonground = true;
    }
}
