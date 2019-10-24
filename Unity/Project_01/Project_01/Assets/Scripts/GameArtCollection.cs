using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameArtCollection : ScriptableObject
{
    public List<GameArtData2> gameArtList;


    public void AddObject(GameArtData2 temp)
    {
        if (!ContainsObject(temp))
        {
            gameArtList.Add(temp);
        }
    }

    public void RemoveObject(GameArtData2 temp)
    {
        if (gameArtList.Contains(temp))
        {
            gameArtList.Remove(temp);
        }
    }

    public bool ContainsObject(GameArtData2 temp)
    {
        return gameArtList.Contains(temp);
    }
}
