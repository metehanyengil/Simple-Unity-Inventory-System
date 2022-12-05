using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    // list of items in the inventory
    public List<Item> items = new List<Item>();

    // maximum number of items that the inventory can hold
    public int maxItems = 10;

    // add an item to the inventory
    public void AddItem(Item item)
    {
        if (items.Count >= maxItems)
        {
            Debug.LogWarning("Inventory is full!");
            return;
        }

        items.Add(item);
        Debug.Log("Added item: " + item.name);
    }

    // remove an item from the inventory
    public void RemoveItem(Item item)
    {
        if (!items.Contains(item))
        {
            Debug.LogWarning("Inventory does not contain item: " + item.name);
            return;
        }

        items.Remove(item);
        Debug.Log("Removed item: " + item.name);
    }

    // check if the inventory contains a specific item
    public bool ContainsItem(Item item)
    {
        return items.Contains(item);
    }
}
