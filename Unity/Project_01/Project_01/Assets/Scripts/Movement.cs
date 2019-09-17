using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 4f;
    public float gravity = -3f;
    public float jumpSpeed = 25f;
    private Vector3 position;
    public CharacterController controller;

    // Update is called once per frame
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");

        if (!controller.isGrounded)
        {
            position.y += gravity;
        }
        else
        {
            position.y = 0;
        }
        
        if (Input.GetButtonDown("Jump") && controller.isGrounded)
        {
            position.y = jumpSpeed;
        }
        //position.y *= Time.deltaTime * Input.GetAxis("Vertical");
        controller.Move(position * Time.deltaTime);

    }
    
}
