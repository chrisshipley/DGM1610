using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoisonScript : MonoBehaviour
{
    public PoisonEffect poison;
    public float poisonDOT = -0.1f;

    public void PoisonPlayer()
    {
        poison.AddTickDamage(poisonDOT);
    }
}
