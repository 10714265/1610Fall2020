
using UnityEngine;
[CreateAssetMenu]
public class FloatData : ScriptableObject
{
   public float value;

   public void UpdateValue(int number)
   {
      value += number;
   }
}
