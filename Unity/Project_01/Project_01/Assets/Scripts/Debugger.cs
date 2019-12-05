using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Debugger : ScriptableObject
{
    private bool debugging = false;
    public void OnDebug(string msg)
    {
        if (debugging)
        {
            Debug.Log(msg);
        }
    }

    public void OnDebug()
    {
        if (debugging)
        {
            Debug.Log(name);
        }
    }
}
