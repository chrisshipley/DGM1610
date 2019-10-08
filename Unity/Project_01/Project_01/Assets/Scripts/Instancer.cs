using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancer : MonoBehaviour
{
    public PlayerData characterCreator;

    // Start is called before the first frame update
    void Start()
    {
        characterCreator.InstancePlayer();
    }

}
