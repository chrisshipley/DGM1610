using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScript : MonoBehaviour
{

    public PlayerData2 playerData;

    // Start is called before the first frame update
    void Start()
    {
        playerData.InstancePlayer();
    }


    // Update is called once per frame
    void Update()
    {
        // Toxic for performance
    }
}
