
using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController mover;
    public Vector3 direction;

    private void Update()
    {
        var moveme = direction * Time.deltaTime;
        mover.Move(moveme);
    }
}
