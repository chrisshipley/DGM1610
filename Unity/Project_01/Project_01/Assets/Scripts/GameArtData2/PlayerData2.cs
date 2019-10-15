using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class PlayerData2 : GameArtData2
{
    public UnityAction<GameObject> instanceAction;

    public FloatData health;
    public List<WeaponData2> weapons;
    public ClothesData shirt;
    public ClothesData pants;

    private float startHealth = 10.0f;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
        health.value = startHealth;
        health.maxValue = startHealth;
        health.minValue = 0.0f;

        instanceAction(newPlayer);
    }
}
