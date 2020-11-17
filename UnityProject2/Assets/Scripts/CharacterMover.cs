
using System;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMover : MonoBehaviour
{
    private CharacterController controller;
    public float moveSpeed = 4f, gravity = -9.81f, jumpForce = 10f;
    

    private Vector3 moveDirection;
    public float yDirection;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var moveSpeedInput = moveSpeed * Input.GetAxis("Horizontal");
        var VertInput = moveSpeed * Input.GetAxis("Vertical");
        moveDirection.Set(moveSpeedInput,yDirection,VertInput);

        
        

        yDirection += gravity * Time.deltaTime;

        if (controller.isGrounded && moveDirection.y < 0)
        {
            yDirection = -1f;
        }
       
        //if (Input.GetButtonDown("Jump"))
        //{
            //yDirection = jumpForce;
       // }
        
        var movement = moveDirection * Time.deltaTime;
        controller.Move(movement);

        
    }
}
