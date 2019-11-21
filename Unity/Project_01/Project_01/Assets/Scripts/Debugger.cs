using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class Debugger : ScriptableObject
{

    public void OnDebug(string msg)
    {
        Debug.Log(msg);
    }

    public void OnDebug()
    {
        Debug.Log(name);
    }
}
