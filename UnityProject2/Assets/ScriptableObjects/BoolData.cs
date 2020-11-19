
using UnityEngine;
[CreateAssetMenu]
public class BoolData : ScriptableObject
{
   public bool value;

   public void UpdateValue(bool newValue)
   {
      value = newValue;
      Debug.Log("Game Over");
   }
}
