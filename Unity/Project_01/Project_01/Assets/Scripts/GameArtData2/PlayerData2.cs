using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class PlayerData2 : GameArtData2
{
    public List<WeaponData2> weapons;
    public ClothesData shirt;
    public ClothesData pants;

    public void InstancePlayer()
    {
        var newPlayer = Instantiate(prefab);
        var newSprite = newPlayer.GetComponentInChildren<SpriteRenderer>();
        newSprite.sprite = sprite;
        newSprite.color = color;
        newPlayer.SetActive(true);
    }
}
