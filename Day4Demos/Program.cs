using System;
using System.Collections.Generic;

namespace Day4Demos
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryItem.SetMaxWeight(1000);

            //Instantiate a list
            List<InventoryItem> items = new List<InventoryItem>();

            //Instantiate and item
            InventoryItem item1 = new InventoryItem();
            //Initializing teh item
            item1.SetSerialNumber(1);
            item1.SetWeight(500);
            //Add item to list
            items.Add(item1);

            //Instantiate and item
            InventoryItem item2 = new InventoryItem();
            //Initializing teh item
            item2.SetSerialNumber(2);
            item2.SetWeight(300);
            //Add item to list
            items.Add(item2);

            

            Console.WriteLine("Count: " + items.Count);
            Console.WriteLine("Capacity: " + items.Capacity);
            Console.WriteLine("Type: "+ items);
            foreach(InventoryItem item in items)
            {
                Console.WriteLine($"Desc: " + item.GetDescription());
            }
        }

        
    }
}
