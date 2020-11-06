using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UnityEvents : MonoBehaviour
{
    public UnityEvent myunityevents;

    public void OnTriggerEnter(Collider other)
    {
        myunityevents.Invoke();
    }
}
