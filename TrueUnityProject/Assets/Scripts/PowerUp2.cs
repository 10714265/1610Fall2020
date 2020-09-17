using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp2 : MonoBehaviour
{
    public int value;

    private void OnTriggerEnter(Collider other)
    {
        value++;
        print(value);
    }
}
