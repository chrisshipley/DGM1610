using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetFruit : MonoBehaviour
{
    public bool appleIsRipe = false;
    public bool pearIsRipe = false;
    public bool orangeIsRipe = false;
    public bool bananaIsRipe = false;
    public bool peachIsRipe = false;

    // Start is called before the first frame update
    void Start()
    {
        if (appleIsRipe)
        {
            Debug.Log("Go pick the apple.");
        }
        else if (pearIsRipe)
        {
            Debug.Log("Go pick the pear.");
        }
        else if (orangeIsRipe)
        {
            Debug.Log("Go pick the orange.");
        }
        else if (bananaIsRipe)
        {
            Debug.Log("Go pick the banana.");
        }
        else if (peachIsRipe)
        {
            Debug.Log("Go pick the peach.");
        }
        else
        {
            Debug.Log("Nothing is ripe.");
        }
        
    }

}
