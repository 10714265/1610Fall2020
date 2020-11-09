using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CollisionDetection : MonoBehaviour
{
    public class UnityEvents : MonoBehaviour
    {
        public CollisionDetection myunityevents;

        public void OnTriggerEnter(Collider other)
        {
            myunityevents.Invoke();
        }
    }
}
