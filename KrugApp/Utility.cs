using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KrugApp
{
    internal class Utility
    {
        /// <summary>
        /// Calculates the number of wines based on a comparison between two arrays of tanks.
        /// </summary>
        /// <param name="a">The first array of Tank objects representing tanks.</param>
        /// <param name="b">The second array of Tank objects representing tanks.</param>
        /// <returns>The calculated number of wines based on the comparison between the two arrays.</returns>
        /*public static int NbrEachWine(Tank[] a, Tank[] b)
        {
            var d = 0; // number of wines

            if (NbrWines(a) == 0)
                return 0; // Return 0 if there are no wines in array a to avoid division by zero

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < a[i].Wine.Length; j++)
                {
                    var tankA = a[i].Wine[j].Quantity;
                    var tankB = b[i].Wine[j].Quantity;
                    if (NbrWines(a) != NbrWines(b))
                        return 0;
                    else if (tankA == tankB)
                        d = d + 2;
                    else if (tankA > tankB && tankB >= (tankA / 2))
                        d += d + 1;
                    else if (tankA < tankB && tankA >= tankB / 2)
                        d += d + 1;
                }
            }

            d = d / NbrWines(a);
            return d;
        }
        */
        /// <summary>
        /// Calculates the number of tanks that have at least two wines.
        /// </summary>
        /// <param name="a">An array of Tank objects representing the tanks.</param>
        /// <returns>The total number of tanks with at least two wines.</returns>
        public static int NbrMix(Tank[] a)
        {
            var sum = 0;
            var total = 0;
            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < a[i].Wine.Length; j++)
                {
                    if (a[i].Wine[j].Quantity >= 1)
                        sum++;
                }
                if (sum >= 2)
                    total++;
                sum = 0;
            }
            return total;
        }

        /// <summary>
        /// Check if the child node moves away from the target in relation to a parent node
        /// </summary>
        /*
        public static bool IsMovingAway(Tank[] parent, Tank[] child, Tank[] target)
        {
            var parentSimilarity = Similarity(parent, target);
            var childSimilarity = Similarity(child, target);

            if (childSimilarity > parentSimilarity)
                return true;
            else
                return false;
        }*/

        /// <summary>
        /// Parses a CSV file containing wine data and returns an array of Wine objects based on the specified quantity index.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <param name="quantityIndex">The index of the quantity column in the CSV.</param>
        /// <returns>An array of Wine objects.</returns>
        public static Wine[] CSVToFormula(string path)
        {
            int quantityIndex = 1;
            path = Path.GetFullPath(path);
            using (var reader = new StreamReader(path))
            {
                Wine[] wines = new Wine[Tank.MAX_WINES];
                for(int i = 0; i < wines.Length; i++)
                {
                    wines[i] = new Wine(0);
                }

                while (!reader.EndOfStream)
                {

                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        continue;
                    }
                    if (line.Length == 0 || line[0] == '#') // Skip empty lines and those starting with #
                    {
                        continue;
                    }
                    var values = line.Split(',');

                    // Parse the quantity value from the CSV column
                    float quantity = float.Parse(values[quantityIndex]);

                    // ignore -1 values
                    if (quantity == -1)
                    {
                        continue;
                    }

                    wines[int.Parse(values[0])] = (new Wine(quantity));
                }
                return wines;
            }
        }


        /// <summary>
        /// Counts the number of lines in a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>The number of lines in the CSV file.</returns>
        static int CountLinesInCSV(string path)
        {
            path = Path.GetFullPath(path);
            try
            {
                int lineCount = 0;
                using (StreamReader reader = new StreamReader(path))
                {
                    while (reader.ReadLine() != null)
                    {
                        lineCount++;
                    }
                }
                return lineCount;
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the CSV file: " + e.Message);
                return 0;
            }
        }


        /// <summary>
        /// Parses a CSV file containing tank data and returns an array of Tank objects.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <param name="size">The size of the Wine array in each Tank object.</param>
        /// <returns>An array of Tank objects.</returns>
        public static Tank[] CSVToTanks(string path, int size)
        {
            path = Path.GetFullPath(path);

            using (var reader = new StreamReader(path))
            {
                int lines = CountLinesInCSV(path);
                Tank[] tanks = new Tank[lines];
                var i = 0;

                // Skip the header row
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (line == null)
                    {
                        break;
                    }
                    if (line.Length == 0 || line[0] == '#')
                    {
                        continue;
                    }
                    var values = line.Split(',');

                    var tank = new Tank();
                    tank.Capacity = (float)int.Parse(values[0]);

                    int wineIndex = int.Parse(values[1]);
                    tank.Wine = new Wine[size];
                    for (var j = 0; j < size; j++)
                    {
                        tank.Wine[j] = new Wine();
                        if (wineIndex > -1)
                        { 
                            tank.Wine[j].Quantity = (j == wineIndex) ? tank.Capacity : 0;
                            tank.IsEmpty = false;
                        }
                    }
                    tanks[i] = tank;
                    i++;
                }

                return tanks;
            }
        }



        /// <summary>
        /// Generates a printable representation of an integer array, including the array elements and their sum.
        /// </summary>
        /// <param name="input">An integer array.</param>
        /// <returns>A printable string representation of the array elements and their sum.</returns>
        public static string printable(int[] input)
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
