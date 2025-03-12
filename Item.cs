using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    public class Item
    {
        public string item;
        private static Random random = new Random();
        public string RandomItem()
        {
            string[] items = { "Sword", "Shield", "Health Potion" }; // creates an array of items
            return item = items[random.Next(items.Length)];// returns a random item from the array 
        }
            
        public Item(string item)
        {
            this.item = item;
        }

        public string GetItem()
        {
            return item;
        }

    }
    
}
