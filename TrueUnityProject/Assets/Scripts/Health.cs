
using System;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
   public int health;
   public UnityEvent healthEvent;

   private void OnTriggerEnter(Collider other)
   {
      health++;
      print(health);
      healthEvent.Invoke();
   }
}
