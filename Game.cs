using System;
using System.IO;
using System.Media;

namespace DungeonExplorer
{
    internal class Game
    {
        private Player player;
        private Room currentRoom;
        private Item currentItem;
        private bool itemExists = true;

        public Game()
        {
            Console.WriteLine("Welcome to Dungeon Explorer!");
            // Ask the player for their name and adds it to a new variable
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            // Create a new player with the name "Player" and 100 health
            player = new Player(name, 100);
            // Create a new room
            currentRoom = new Room("You are in a dark room with puddles");
            currentItem = new Item("Health Potion");


        }
        public void Start()
        {
            // Change the playing logic into true and populate the while loop
            bool playing = true;
            while (playing)
            {
                Console.WriteLine("What do you want to do?");
                string command = Console.ReadLine();
                // If the command is "quit", set playing to false
                if (command == "quit")
                {
                    playing = false;
                }
                // If the command is "pickup", ask the player for an item and add it to the player's inventory
                else if (command == "next room")   // If the player enters 'next room' the room and related items are generated
                {
                    Console.WriteLine("Entered the next room"); // Inform the player that they've entered the room
                    currentRoom.RandomDescription();   // Method is called to generate a random room description
                    currentItem.RandomItem(); // Method is called to generate a random item
                    Console.WriteLine(currentRoom.GetDescription()); // the room description is printed to the console
                    itemExists = true; // the itemExists variable is set to true
                }
                else if (command == "pickup")
                {
                    
                    if (itemExists == true) // If the item exists in the room, the player is asked if they want to pick it up
                    {
                        Console.WriteLine("Do you want to pickup the " + currentItem.GetItem() + "? (yes/no)");
                        string answer = Console.ReadLine();
                        if (answer == "yes" && itemExists == true)
                        {
                            player.PickUpItem(currentItem.GetItem());
                            Console.WriteLine("You picked up a " + currentItem.GetItem()); // the item is picked up and added to the player's inventory
                            itemExists = false; // the itemExists variable is set to false which means
                                                // the item is no longer in the room and cannot be picked up again

                        }
                        else if (answer == "no")
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Unknown command, type 'yes' or 'no'");
                        }
                    }
                    else
                    {
                        Console.WriteLine("There are no items to pick up");
                    }


                }
                // If the command is "help", print a list of commands
                else if (command == "help")
                {
                    Console.WriteLine("Commands:" + // List of commands that the player can use
                        "\nquit : exit game" +
                        "\nhelp : pull up command list" +
                        "\npickup : pickup current item" +
                        "\nlook around : look around the room for items" +
                        "\ninventory : check player inventory" +
                        "\nplayer : check player health" +
                        "\nnext room : move onto the next room");
                }
                // If the command is not recognized, print an error message
                else if (command == "inventory")
                {
                    Console.WriteLine("You have the following items: ");
                    Console.WriteLine(player.InventoryContents());
                }
                else if (command == "player") // If the player enters 'player' the player's name and health are displayed
                {
                    Console.WriteLine("Player name : " +player.Name);
                    Console.WriteLine("Player health : "+ player.Health);
                }
                else if (command == "look around") // If the player enters 'look around' the items in the room are displayed
                {
                   if (itemExists == true)
                    {
                        Console.WriteLine("You see a " + currentItem.GetItem());
                    }
                    else
                    {
                        Console.WriteLine("There are no items in this room");
                    }
                }
                else
                {
                    Console.WriteLine("Unknown command, type 'help' for a list of commands");
                }
            }
        }
    }
}