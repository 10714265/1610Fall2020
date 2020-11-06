using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PowerUp : MonoBehaviour
{
    public UnityEvent mypowerup;
    public int ammo = 100;
    private void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        ammo++;
        print(ammo);
        mypowerup.Invoke();
    }
}
