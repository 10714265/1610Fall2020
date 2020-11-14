
using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEvents : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;


    private void OnTriggerEnter(Collider other)
    {
        triggerEnterEvent.Invoke();
    }
}

