
using System;
using UnityEngine;

public class Health : MonoBehaviour
{
   public int health;

   private void OnTriggerEnter(Collider other)
   {
      health++;
      print(health);
   }
}
