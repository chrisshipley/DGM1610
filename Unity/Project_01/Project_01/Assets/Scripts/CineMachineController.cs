using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]

public class CineMachineController : MonoBehaviour
{
    private CinemachineVirtualCamera virtualCamera;
    public PlayerData2 playerData;

    void Awake()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
        playerData.instanceAction = InstanceHandler;
        playerData.InstancePlayer();
    }


    private void InstanceHandler(GameObject obj)
    {
        virtualCamera.Follow = obj.transform;
    }
}
