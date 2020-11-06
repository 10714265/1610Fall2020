
using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    private CharacterController mover;
    public Vector3 direction;

    private void Update()
    {
        mover.Move(direction);
    }
}
