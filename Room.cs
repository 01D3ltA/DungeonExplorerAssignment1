using System;

namespace DungeonExplorer
{
    public class Room
    {
        private string description;
        
        private static Random random = new Random();
        
        public string RandomDescription()
        {
            string[] descriptions =
            {"You are in a dark room with puddles",
             "You are in a bright room filled with plants",
             "You are in a cave-like room with lava",
             "You are in a old, musty libary"}; // creates an array of descriptions
            return description = descriptions[random.Next(descriptions.Length)]; // returns a random description from the array
            
        }
        public Room(string description)
        {
            this.description = description;
        }

        public string GetDescription()
        { 
            return description;
        }
        
    }
}