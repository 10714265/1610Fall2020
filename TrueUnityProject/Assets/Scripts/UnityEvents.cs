
using System;
using UnityEngine;
using UnityEngine.Events;
public class UnityEvents : MonoBehaviour
{
    public UnityEvent myUnityEvent;

    private void OnTriggerEnter(Collider other)
    {
        myUnityEvent.Invoke(); 
    }
}
