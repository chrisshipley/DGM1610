using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> inventory;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public string ListInventory()
    {
        string list = "";
        for (int i = 0; i < inventory.ToArray().Length; ++i)
        {
            list += inventory[i].name + "\n";
        }
        return list;
    }


    public void AddToInventory(Item newItem)
    {
        inventory.Add(newItem);

    }


    public Item GetItem(string itemName)
    {
        Item receiver = null;
        for (int i = 0; i < inventory.ToArray().Length; ++i)
        {
            if (inventory[i].name == itemName)
            {
                receiver = inventory[i];
                break;
            }
        }

        return receiver;
    }


    public void RemoveFromInventory(string itemName)
    {
        Item remover = GetItem(itemName);
        if (remover == null)
        {
            Debug.Log("There is not an item: \"" + itemName + "\" in this inventory.");
        }
        else
        {
            RemoveItem(remover);
        }
    }


    private void RemoveItem(Item removedItem)
    {
        inventory.Remove(removedItem);
    }
}
