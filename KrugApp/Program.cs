using System;
using KrugApp;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the wines and their quantities in the given formula
            Wine[] formula = new Wine[]
            {
                new Wine(2),
                new Wine(8),
                new Wine(250),
                new Wine(150),
            };

            // Create an array of tanks
            Tank[] tanks = new Tank[5];
            for (int i = 0; i < tanks.Length; i++)
                tanks[i] = new Tank();

            foreach (Tank t in tanks)
            {
                Console.WriteLine("Object : "+t);
                Console.WriteLine("Capacity : " + ((int)t.Capacity));
                Console.WriteLine("Total wine : " + t.Wine.Sum(w => w.Quantity));
            }
            tanks.OrderBy(tank => tank.Capacity);

            // possibility of transfert

            Console.WriteLine("\n\tDone");
            Console.Read();
        }


    }
}
