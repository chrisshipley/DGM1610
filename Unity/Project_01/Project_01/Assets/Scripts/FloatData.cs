using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value = 0.0f;

    public void UpdateValue(float amount)
    {
        value += amount;
    }
}
