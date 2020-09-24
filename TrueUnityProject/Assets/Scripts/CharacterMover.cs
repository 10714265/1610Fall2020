using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 moveDirection, movement;
    public float moveSpeed = 3f, gravity = -9.81f;
    
        // Start is called before the first frame update
        private void Update()
        {
            var moveSpeed
            moveDirection.Set(moveSpeed, 0, 0);
            movement = moveDirection * Time.deltaTime;
            controller.Move(moveDirection);
        }
        
}