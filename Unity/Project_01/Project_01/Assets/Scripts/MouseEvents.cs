using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseEvents : MonoBehaviour
{
    private Camera cam;
    public Vector3Data destination;

    private void Start()
    {
        cam = Camera.main;
    }

    private void OnMouseDown()
    {
        Debug.Log(cam.ScreenToWorldPoint(Input.mousePosition));
        destination.value = cam.ScreenToWorldPoint(Input.mousePosition);
    }




}
