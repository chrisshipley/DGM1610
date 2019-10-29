using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuggerHandler : MonoBehaviour
{
    public Debugger debuggerObj;

    // Update is called once per frame
    void Update()
    {
        debuggerObj.OnDebug();
    }


    public void SwitchDebugger(Debugger newDebuggerObj)
    {
        debuggerObj = newDebuggerObj;
    }
}
