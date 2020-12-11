using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour
{
    int enemiesRemaining = 10;
    
    
    void Start ()
    {
        while(enemiesRemaining > 0)
        {
            Debug.Log ("Enemy Slain");
            enemiesRemaining--;
        }
    }
}
