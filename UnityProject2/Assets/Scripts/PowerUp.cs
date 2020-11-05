using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public int scoreboi;
    private void OnTriggerEnter(Collider other)
    {
        scoreboi++;
        print(scoreboi);
    }
}
