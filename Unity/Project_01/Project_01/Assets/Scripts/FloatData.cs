using UnityEngine;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value = 0.0f;
    public float maxValue;
    public float minValue;

    public void UpdateValue(float amount)
    {
        value += amount;
        if (value > maxValue)
        {
            value = maxValue;
        }
        else if (value < minValue)
        {
            value = minValue;
        }
    }
}
