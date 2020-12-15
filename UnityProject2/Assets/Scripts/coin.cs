using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class coin : ScriptableObject
{
   public List<Transform> collectedtransform;

   public void Collect(Transform obj)
   {
      collectedtransform.Add(obj);
   }

   public void PrintCollection()
   {
      foreach (var obj in collectedtransform)
      {
         Debug.Log(obj);
      }
   }
}
