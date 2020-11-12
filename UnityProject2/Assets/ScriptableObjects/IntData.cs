
using UnityEngine;
using UnityEngine.PlayerLoop;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
    public int value;

    public void UpdateValue(int number)
    {
        value += number;
        Debug.Log(value);
    }
    
}

