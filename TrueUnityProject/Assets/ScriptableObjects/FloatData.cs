
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class FloatData : ScriptableObject
{
    public float value;

    public void UpdateValue(float number)
    {
        value += value + number;
    }

    public void DisplayImage(Image img)
    {
        img.fillAmount = value;
    }
}
