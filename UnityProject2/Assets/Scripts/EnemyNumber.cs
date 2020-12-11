using UnityEngine;
using System.Collections;

public class EnemyNumber : MonoBehaviour
{
    int numberEnemies = 3;
    
    
    void Start ()
    {
        for(int i = 0; i < numberEnemies; i++)
        {
            Debug.Log("Enemy: " + i);
        }
    }
}
