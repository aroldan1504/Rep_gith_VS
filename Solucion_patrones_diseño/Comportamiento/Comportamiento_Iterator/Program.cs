using System;


namespace Comportamiento_Iterator
{
    class Program
    {
        class MainApp

        {
            static void Main()
            {
                // Build a collection

                Collection collection = new Collection();
                collection[0] = new Item("Articulo 0");
                collection[1] = new Item("Articulo 1");
                collection[2] = new Item("Articulo 2");
                collection[3] = new Item("Articulo 3");
                collection[4] = new Item("Articulo 4");
                collection[5] = new Item("Articulo 5");
                collection[6] = new Item("Articulo 6");
                collection[7] = new Item("Articulo 7");
                collection[8] = new Item("Articulo 8");

                // Create iterator

                Iterator iterator = collection.CreateIterator();

                // Skip every other item

                iterator.Step = 2;

                Console.WriteLine("Iterando sobre la colección: ");

                for (Item item = iterator.First();
                    !iterator.IsDone; item = iterator.Next())
                {
                    Console.WriteLine(item.Name);
                }

                // Wait for user

                Console.ReadKey();
            }
        }
    }
}
