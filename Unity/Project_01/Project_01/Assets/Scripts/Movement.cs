using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class Movement : MonoBehaviour
{
    public float moveSpeed = 6f;
    public float gravity = 1.5f;
    public float jumpSpeed = 22f;
    private CharacterController controller;
    private Vector3 position;

    private int jumps = 0;
    private int maxJumps = 2;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        position.x = moveSpeed * Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump") && (controller.isGrounded || jumps < maxJumps))
        {
            ++jumps;
            position.y = jumpSpeed;
        }
        else if (!controller.isGrounded)
        {
            position.y -= gravity;
        }
        else
        {
            position.y = 0;
            jumps = 0;
        }

        

        controller.Move(position * Time.deltaTime);
    }
}
