using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpenSecond : MonoBehaviour
{
    public GameObject theDoor;
    //public AudioSource doorFX;

    void OnTriggerEnter(Collider other)
    {
        //doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorOpenTwo");
        this.GetComponent<BoxCollider>().enabled = false;
        StartCoroutine(CloseDoor());
    }

    IEnumerator CloseDoor()
    {
        yield return new WaitForSeconds(5);
        //doorFX.Play();
        theDoor.GetComponent<Animator>().Play("DoorCloseTwo");
        this.GetComponent<BoxCollider>().enabled = true;
    }
}
