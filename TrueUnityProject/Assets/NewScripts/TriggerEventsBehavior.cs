
using System;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehavior : MonoBehaviour
{
    public UnityEvent TriggerEnterEvent;

    private void OnTriggerEnter(Collider other)
    {
        TriggerEnterEvent.Invoke();
    }
}

