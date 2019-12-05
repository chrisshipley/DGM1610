using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DogClass : MonoBehaviour
{
    public GameObject light;

    private void OnMouseDown()
    {
        this.gameObject.SetActive(false);
        light.SetActive(true);
    }
}
