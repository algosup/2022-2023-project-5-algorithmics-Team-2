using System;
using System.Linq;
using KrugApp;

namespace KrugApp
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
            Tank[] tanks = new Tank[10];
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

            //foreach (Tank tank in tanks)
            //{
            //    Console.WriteLine(tank);
            //}

            Tank[] tankValues = tanks.ToArray();
            List<int[]> sumCombinations = Tank.GenerateSumCombinations(tankValues);

            // Iterate over the sum combinations

            for (int i = 0; i < sumCombinations.Count; i++)
            {
                Console.WriteLine(printable(sumCombinations[i]));
            }


/*
            foreach (int[] combination in sumCombinations)
            {
                Console.WriteLine($"Combination for Tank {index} of capacity {tanks[index].Capacity} :");
                foreach (int value in combination)
                {
                    Console.Write(value + "-");
                }
                Console.WriteLine();
                index++;
            }
*/


            Console.WriteLine("\n\tDone");
            foreach (var tank in tanks)
            {
                Console.Write(tank.Capacity + ", ");
            }
                
            Console.Read();

        }
        static string printable(int[] input)
        {
            var a = String.Empty;

            foreach (var b in input)
                a = a + "," + b.ToString();

            a = a.TrimStart(',');

            a = a + " : " + input.Sum();
            return a;
        }

    }
}
