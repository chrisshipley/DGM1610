using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData2> collectionList;


    public void AddObject(GameArtData2 temp)
    {
        collectionList.Add(temp);
    }

    public void RemoveObject(GameArtData2 temp)
    {
        if (collectionList.Contains(temp))
        {
            collectionList.Remove(temp);
        }
    }
}
