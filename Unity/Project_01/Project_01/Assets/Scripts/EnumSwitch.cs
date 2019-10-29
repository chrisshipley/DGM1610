using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnumSwitch : MonoBehaviour
{
    public enum States { Start, Playing, End };

    public States currentState;
    public UnityEvent OnStartEvent, OnPlayingEvent, OnEndEvent;

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case States.Start:
                OnStartEvent.Invoke();
                currentState = States.Playing;
                break;

            case States.Playing:
                OnPlayingEvent.Invoke();
                currentState = States.End;
                break;

            case States.End:
                OnEndEvent.Invoke();
                currentState = States.Start;
                break;

            default:
                throw new ArgumentOutOfRangeException();
        }

    }
}
