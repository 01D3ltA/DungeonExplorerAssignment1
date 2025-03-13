using System.Collections.Generic;

namespace DungeonExplorer
{
    public class Player
    {
        public string Name { get; private set; } // creates a property for the player's name
        public int Health { get; private set; } //  creates a property for the player's health
        private List<string> inventory = new List<string>(); // creates a list of strings for the player's inventory

        public Player(string name, int health) // creates a constructor for the player
        {
            Name = name;
            Health = health;
        }
        public void PickUpItem(string item)
        {
            inventory.Add(item); // adds an item to the player's inventory
        }
        public string InventoryContents()
        {
            return string.Join(", ", inventory);
        }
    }
}