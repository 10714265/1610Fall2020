using UnityEngine;
using System.Collections;

public class StringAttach : MonoBehaviour 
{   
    void Start () 
    {
        string[] strings = new string[3];
        
        strings[0] = " ";
        strings[1] = " ";
        strings[2] = " ";
        
        foreach(string item in strings)
        {
            print (item);
        }
    }
}