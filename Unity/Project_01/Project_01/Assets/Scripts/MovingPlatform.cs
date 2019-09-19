using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class MovingPlatform : MonoBehaviour
{
    public float yMin, yMax;
    private Vector3 position;
    private Rigidbody controller;
    private Vector3 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        startPosition = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.position.y > startPosition.y - yMin)
        {

        }

        controller.MovePosition(position * Time.deltaTime);
    }
}
