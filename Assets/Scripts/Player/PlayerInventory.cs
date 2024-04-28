using UnityEngine;
using System.Collections.Generic;

public class PlayerInventory : MonoBehaviour
{
    // Inventory list
    private List<int> inventory = new List<int>();

    // Add an item to the inventory
    public void AddItem(int itemId)
    {
        inventory.Add(itemId);
    }

    // Remove an item from the inventory
    public void RemoveItem(int itemId)
    {
        inventory.Remove(itemId);
    }

    // Check if the inventory contains a specific item
    public bool HasItem(int itemId)
    {
        return inventory.Contains(itemId);
    }

    // Get the inventory count
    public int GetInventoryCount()
    {
        return inventory.Count;
    }

    // Clear the entire inventory
    public void ClearInventory()
    {
        inventory.Clear();
    }
}
