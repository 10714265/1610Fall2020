
using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController mover;
    public Vector3 direction, movement;
    public float moveSpeed = 3f;
    public float gravity = -9.81f;
    public float jumpForce = 30f;

    private void Update()
    {
        var movespeedInput = moveSpeed * Input.GetAxis("Horizontal");
        direction.Set(movespeedInput, gravity, 0);
       
        if (Input.GetButtonDown("Jump"))
        {
            direction.y += jumpForce;
        }
        
        movement = direction * Time.deltaTime;
        mover.Move(movement);

        
    }
}
