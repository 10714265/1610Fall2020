
using System;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController mover;
    public Vector3 direction, movement;
    public float moveSpeed = 3f, moveupDown = 3f;
    public float gravity = -9.81f;
    public float jumpForce = 30f;

    public float yDirection;
    private void Update()
    {
        var movespeedInput = moveSpeed * Input.GetAxis("Horizontal");
        var moveupdownInput = moveupDown * Input.GetAxis("Vertical");
        direction.Set(movespeedInput, yDirection, moveupdownInput);

        yDirection += gravity * Time.deltaTime;

        if (mover.isGrounded && direction.y < 0)
        {
            yDirection = -1f;
        }
       
        if (Input.GetButtonDown("Jump"))
        {
            yDirection = jumpForce;
        }
        
        movement = direction * Time.deltaTime;
        mover.Move(movement);

        
    }
}
