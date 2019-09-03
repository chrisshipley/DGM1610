using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public double healthPoints; // The health point value of the character
    public string name; // Name of the character
    public Inventory inventory; // A list of generic Items

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void AddItem(Item newItem)
    {
        inventory.AddToInventory(newItem);
    }

    void RemoveItem(string itemName)
    {
        inventory.RemoveFromInventory(itemName);
    }
}
