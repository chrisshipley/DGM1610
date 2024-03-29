﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class IntData : ScriptableObject
{
    public int value = 1;
    
    public void UpdateValue(int x)
    {
        value += x;
    }

    public void SetValue(int x)
    {
        value = x;
    }
}
