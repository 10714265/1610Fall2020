
using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController mover;
    public Vector3 direction;
    public float moveSpeed = 3f;

    private void Update()
    {
        direction.Set(moveSpeed, 0, 0);
        mover.Move(direction);
    }
}
