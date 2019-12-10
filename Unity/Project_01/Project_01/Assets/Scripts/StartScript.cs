using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartScript : MonoBehaviour
{
    public PlayerData2 playerData;
    public IntData score;
    public FloatData health;
    public PoisonEffect poison;
    public Image victoryScreen;
    public Image defeatScreen;

    void Awake()
    {
        score.SetValue(0);
        health.SetValue(health.maxValue);
        poison.ResetTickDamage();
        victoryScreen.gameObject.SetActive(false);
        defeatScreen.gameObject.SetActive(false);
    }

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
