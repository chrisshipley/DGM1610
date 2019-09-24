using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MovingPlatform : MonoBehaviour
{
    public float yMin, yMax;
    public bool positiveDirection;
    public float moveSpeed;
    private Vector3 position;
    private Rigidbody controller;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
        controller = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (positiveDirection)
        {
            if (controller.position.y > startPosition.y + yMin)
            {
                positiveDirection = false;
            }
            else
            {
                position.y += (.5f * moveSpeed);
            }
        }
        else
        {
            if (controller.position.y < startPosition.y - yMin)
            {
                positiveDirection = true;
            }
            else
            {
                position.y -= (.5f * moveSpeed);
            }
        }

        controller.MovePosition(position * Time.deltaTime);
    }
}
