using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntidoteScript : MonoBehaviour
{
    public List<GameObject> poisonTraps;

    public void CurePlayer()
    {
        for (int i = 0; i < poisonTraps.Count; ++i)
        {
            poisonTraps[i].GetComponent<PoisonScript>().poisoned = false;
            poisonTraps[i].GetComponent<PoisonScript>().StopAllCoroutines();
        }
    }
}
