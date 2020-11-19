
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]

public class StringListData : ScriptableObject
{
    public List<string> valuie;
    private int index = 0;

    private void OnEnable()
    {
        index = 0;
    }

    public void UpdatemyText (Text txt)
    {
        txt.text = valuie[index];
        index = (index + 1) % valuie.Count;
    }
}
