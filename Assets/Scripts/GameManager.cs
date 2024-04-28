using UnityEngine;
using System.Collections.Generic;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    // Player data
    public string playerName;
    public int playerHealth;
    public int playerArmor;

    // Inventory
    public List<int> inventory = new List<int>();

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Method to save player data
    public void SavePlayerData()
    {
        PlayerPrefs.SetString("PlayerName", playerName);
        PlayerPrefs.SetInt("PlayerHealth", playerHealth);
        PlayerPrefs.SetInt("PlayerArmor", playerArmor);

        // Save inventory
        PlayerPrefs.SetInt("InventorySize", inventory.Count);
        for (int i = 0; i < inventory.Count; i++)
        {
            PlayerPrefs.SetInt("InventoryItem_" + i, inventory[i]);
        }

        PlayerPrefs.Save();
    }

    // Method to load player data
    public void LoadPlayerData()
    {
        playerName = PlayerPrefs.GetString("PlayerName");
        playerHealth = PlayerPrefs.GetInt("PlayerHealth");
        playerArmor = PlayerPrefs.GetInt("PlayerArmor");

        // Load inventory
        inventory.Clear();
        int inventorySize = PlayerPrefs.GetInt("InventorySize");
        for (int i = 0; i < inventorySize; i++)
        {
            int itemId = PlayerPrefs.GetInt("InventoryItem_" + i);
            inventory.Add(itemId);
        }
    }

    // Method to add item to inventory
    public void AddItemToInventory(int itemId)
    {
        inventory.Add(itemId);
    }

    // Method to remove item from inventory
    public void RemoveItemFromInventory(int itemId)
    {
        inventory.Remove(itemId);
    }
}
