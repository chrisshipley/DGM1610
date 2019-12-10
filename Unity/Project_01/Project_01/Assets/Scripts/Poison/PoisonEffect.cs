using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PoisonEffect : ScriptableObject
{
    public FloatData health;
    private float tickDamage = 0;

    public void AddTickDamage(float x)
    {
        tickDamage += x;
    }

    public void ResetTickDamage()
    {
        tickDamage = 0;
    }

    public float GetTickDamage()
    {
        return tickDamage;
    }
}
