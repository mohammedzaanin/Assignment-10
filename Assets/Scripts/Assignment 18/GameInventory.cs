using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class GameInventory : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Inventory potions = new Inventory();
        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");
        Inventory elixirs = new Inventory();
        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");
        Debug.Log("Inventory Items: ");
        Inventory combined_inventory = potions+ elixirs;
        combined_inventory.ShowItems();

    }
}
}
