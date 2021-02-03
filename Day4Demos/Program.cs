using System;
using System.Collections.Generic;

namespace Day4Demos
{
    //Blah blah blah
    //TODO: Don't forget your comment header! RJG
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem.SetMaxWeight(1000);

            //Instantiate a list
            List<InventoryItem> items = new List<InventoryItem>();

            do
            {
                try
                {
                    //Instantiate and item
                    InventoryItem item = new InventoryItem();

                    GetItemFromUser(item);

                    //Add item to list
                    items.Add(item);
                }
                catch (Exception exc)
                {
                    Console.WriteLine(exc.Message);
                }

            } while (DoAnother());

            DisplayItems(items);
        }

        private static void DisplayItems(List<InventoryItem> items)
        {
            //Display items
            Console.WriteLine("List of items in inventory: ");
            foreach (InventoryItem item in items)
            {
                Console.WriteLine($"Desc: " + item.GetDescription());
            }
        }

        private static void GetItemFromUser(InventoryItem item)
        {
            item.Id = int.Parse(GetStringFromUser("Id: "));
            item.SerialNumber = int.Parse(GetStringFromUser("Serial Number: "));
            item.Weight = double.Parse(GetStringFromUser("Weight: "));
        }

        private static bool DoAnother()
        {
            Console.Write("Do another (y/n)? ");
            return Console.ReadLine().ToLower()[0] == 'y';
        }

        private static string GetStringFromUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

    }
}
