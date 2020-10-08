using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp2 : MonoBehaviour
{
    public int value;
    public UnityEvent powerUpTwoEvent;

    private void OnTriggerEnter(Collider other)
    {
        value++;
        print(value);
        powerUpTwoEvent.Invoke();

    }
}
