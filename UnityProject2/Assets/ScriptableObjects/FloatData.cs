
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
   public float value;

   public void UpdateValue(float number)
   {
      value += number;
      Debug.Log(value);
   }

   public void ReplaceValue(float number)
   {
      value = number;
   }
   
   public void DisplayImage(Image img)
   {
      img.fillAmount = value;
   }

   public void DisplayNumber(Text txt)
   {
      txt.text = value.ToString();
   }
}
