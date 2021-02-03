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
            try
            {
                //Instantiate and item
                InventoryItem item1 = new InventoryItem();
                //Initializing the item
                item1.Id = 1; //Assign into property
                item1.SetSerialNumber(1);//Call a set method (mutator)
                item1.SetWeight(500);
                //Add item to list
                items.Add(item1);

                //Instantiate and item
                InventoryItem item2 = new InventoryItem();
                //Initializing teh item
                item2.Id = -1; //Assign into property
                item2.SetSerialNumber(2);
                item2.SetWeight(300);
                //Add item to list
                items.Add(item2);

            }
            catch (Exception exc)
            {
                Console.WriteLine(exc.Message);
            }

            

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
