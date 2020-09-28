using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
   public CharacterController controller;
   public float moveSpeed = 5f, gravity = -9.81f, jumpForce = 10f;
   
   
   
   private Vector3 moveDirection;
   private float yDirection;


   private void Update()
   {
      var moveSpeedInput = moveSpeed * Input.GetAxis("Horixontal");

      yDirection += gravity * Time.deltaTime;

      if (controller.isGrounded && moveDirection.y < 0)
      {
         yDirection = -1f;
      }

      if (Input.GetButtonDown("Jump"))
      {
         yDirection = jumpForce;
      }
      
      moveDirection.Set(moveSpeedInput,0,0);
      controller.Move(moveDirection*Time.deltaTime);

      var movement = moveDirection * Time.deltaTime;
      controller.Move(movement);
   }
}