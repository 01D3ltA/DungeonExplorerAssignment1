using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonExplorer
{
    class Test
    {
        public static void RunTest()
        {
            TestInv();
            TestRooms();
            Console.WriteLine("Tests Passed Successfully");
        }
        static void TestInv()
        {
            Item testitem = new Item("TestSword");
            if (testitem.GetItem() != "TestSword")
            {
                throw new Exception("TestInv failed: Item name does not match.");
            }

            Player testPlayer = new Player("TestPlayer", 100);
            testPlayer.PickUpItem(testitem.GetItem());

            if (!testPlayer.InventoryContents().Contains("TestSword"))
            {
                throw new Exception("TestInv failed: Item was not added to the inventory.");
            }
        }

        static void TestRooms()
        {
            Room testRoom = new Room("Test Room Description");
            if (testRoom.GetDescription() != "Test Room Description")
            {
                throw new Exception("TestRooms failed: Room description does not match.");
            }
        }

    }

}
