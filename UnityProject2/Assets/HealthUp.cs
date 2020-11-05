using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    public int healthMy = 100;
    private void OnTriggerEnter(Collider other)
    {
        healthMy++;
        print(healthMy);
    }
}
