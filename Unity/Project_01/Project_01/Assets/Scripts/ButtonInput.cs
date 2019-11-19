using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInput : MonoBehaviour
{
    public UnityEvent inputEvent;
    public string inputWord;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown(inputWord))
        {
            inputEvent.Invoke();
        }
    }
}
