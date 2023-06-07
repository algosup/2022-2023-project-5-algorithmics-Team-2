using System;
using System.Linq;
using KrugApp;

using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;

namespace KrugApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var tanksIn = ReadCSV("./formulaTest.csv");

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

        ///<summary>
        ///Reads the CSV file and returns a List of Wine objects
        ///</summary>
        static Wine[] ReadCSV(string path)
        {
            var reader = new StreamReader(File.OpenRead(path));
            List<string> wine_name = new List<string>();
            List<float> quantity = new List<float>();

            reader.ReadLine();
            
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                
                wine_name.Add(values[0]);
                // float.Parse(values[1], CultureInfo.InvariantCulture.NumberFormat);
                // float asd = (float) Convert.ToDouble(values[1]);
                // float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture)
                quantity.Add(float.Parse(values[1], System.Globalization.CultureInfo.InvariantCulture));

                
            }
            foreach (var coloumn1 in wine_name)
            {
                Console.WriteLine(coloumn1);
            }
            foreach (var coloumn2 in quantity)
            {
                Console.WriteLine(coloumn2);
            }
            var wines = new Wine[wine_name.Count];
            for (int i = 0; i < wine_name.Count; i++)
            {
                wines[i] = new Wine(quantity[i]);
            }
            return wines;
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
