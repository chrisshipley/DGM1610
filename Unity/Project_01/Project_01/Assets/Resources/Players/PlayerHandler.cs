using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class PlayerHandler : ScriptableObject
{
    public PlayerData2 playerDataObj;

    public void SwitchPlayer(PlayerData2 data)
    {
        playerDataObj = data;
    }

    // Update is called once per frame
    public void OnRun()
    {
        playerDataObj.Run();
    }
}
