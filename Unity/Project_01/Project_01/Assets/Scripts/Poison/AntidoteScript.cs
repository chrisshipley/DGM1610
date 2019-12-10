using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntidoteScript : MonoBehaviour
{
    public PoisonEffect poison;

    public void CurePlayer()
    {
        poison.ResetTickDamage();
    }
}
