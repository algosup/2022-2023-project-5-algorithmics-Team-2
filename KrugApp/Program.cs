using System;
using System.Linq;
using KrugApp;

using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace KrugApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string csvFilePath = "formulaTest.csv";

            Wine[] wines = CSVToFormula(csvFilePath);

            //for (var i = 0; i < wines.Length; i++)
            //{
            //    Console.WriteLine($" {i} -> Quantity: {wines[i].Quantity}");
            //}
            var a = String.Empty;

            foreach (var b in wines)
                a = a + "," + b.ToString();

            a = a.TrimStart(',');

            Console.WriteLine(a);

            string filePath = "tank.csv";
            Tank[] tanks = CSVToTank(filePath, wines.Length);
            Console.WriteLine(tanks.Length);
            foreach (Tank tank in tanks)
            {
                //Console.WriteLine($"Tank Capacity: {tank.Capacity}");
                //Console.WriteLine("Wines:");
                if (tank.Wine != null)
                {
                    foreach (Wine wine in tank.Wine)
                    {
                        Console.WriteLine($"- Quantity: {wine.Quantity}");
                    }
                }
                Console.WriteLine();
            }


        }

        /// <summary>
        /// This function compare multiple criteria to know the similarity between two Tank[]
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>The similarity indicator between 0(opposite) and 10(same)</returns>
        /// <exception cref="ArgumentException"></exception>
        public static int Similarity(Tank[] a, Tank[] b)
        {
            if (a == null || b == null || a.Length == 0 || b.Length == 0)
                throw new ArgumentException("Both arrays must have at least one element.");

            // Number of used tank
            var usedTank = SimiPoint(NbrTank(a), NbrTank(b));

            // Number of wines in the tanks
            var nbrWine = SimiPoint(NbrWines(a), NbrWines(b));

            // The total quantity of all the wines
            var nbrQuan = SimiPoint(NbrTotalWine(a), NbrTotalWine(b));

            // The quantity for each wines
            var QuanWine = NbrEachWine(a, b);

            var similarity = usedTank + nbrWine + nbrQuan + QuanWine;

            if (similarity == 8)
                similarity += 2;
            else if (similarity == 7)
                similarity += 1;

            // return similarity (int)
            return similarity;

        }

        /// <summary>
        /// Calculates the similarity point between two integers.
        /// </summary>
        /// <param name="c">The first integer.</param>
        /// <param name="d">The second integer.</param>
        /// <returns>The similarity point based on the comparison between the two integers.</returns>
        public static int SimiPoint(int c, int d)
        {
            if (c == d)
                return 2;
            else if (c > d && c / 2 <= d)
                return 1;
            else if (c < d && d / 2 <= c)
                return 1;
            else
                return 0;
        }

        /// <summary>
        /// Calculates the number of wines in an array of tanks.
        /// </summary>
        /// <param name="a">An array of Tank objects representing tanks.</param>
        /// <returns>The number of wines in the array of tanks.</returns>
        public static int NbrWines(Tank[] a)
        {
            var d = 0; // number of wines
            for (var i = 0; i < a.Length; i++)
                for (var j = 0; j < a[i].Wine.Length; j++)
                    if ((int)a[i].Wine[j].Quantity > 0)
                        d += 1;
            return d;
        }

        /// <summary>
        /// Calculates the number of tanks with non-zero quantity of wine.
        /// </summary>
        /// <param name="a">An array of Tank objects representing tanks.</param>
        /// <returns>The number of tanks with non-zero quantity of wine.</returns>
        public static int NbrTank(Tank[] a)
        {
            float c = 0; // Quantity of wine in the tank
            var d = 0; // number of used tank
            foreach (var tank in a)
            {
                foreach (var wine in tank.Wine)
                    c += wine.Quantity;

                if (c != 0)
                    d += 1;
                c = 0;
            }
            return d;
        }

        /// <summary>
        /// Calculates the total quantity of wine in an array of tanks.
        /// </summary>
        /// <param name="a">An array of Tank objects representing tanks.</param>
        /// <returns>The total quantity of wine in the array of tanks.</returns>
        public static int NbrTotalWine(Tank[] a)
        {
            int wine1 = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Wine.Length; j++)
                {
                    wine1 += (int)a[i].Wine[j].Quantity;
                }
            }
            return wine1;
        }

        /// <summary>
        /// Calculates the number of wines based on a comparison between two arrays of tanks.
        /// </summary>
        /// <param name="a">The first array of Tank objects representing tanks.</param>
        /// <param name="b">The second array of Tank objects representing tanks.</param>
        /// <returns>The calculated number of wines based on the comparison between the two arrays.</returns>
        public static int NbrEachWine(Tank[] a, Tank[] b)
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
        public static bool IsMovingAway(Tank[] parent, Tank[] child, Tank[] target)
        {
            var parentSimilarity = Similarity(parent, target);
            var childSimilarity = Similarity(child, target);

            if (childSimilarity > parentSimilarity)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Parses a CSV file containing wine data and returns an array of Wine objects based on the specified quantity index.
        /// </summary>
        /// <param name="path">The path to the CSV file.</param>
        /// <param name="quantityIndex">The index of the quantity column in the CSV.</param>
        /// <returns>An array of Wine objects.</returns>
        public static Wine[] CSVToFormula(string path)
        {
            int quantityIndex = 1;
            using (var reader = new StreamReader(path))
            {
                List<Wine> wines = new List<Wine>();

                // Skip the header line
                reader.ReadLine();

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    // Parse the quantity value from the CSV column
                    float quantity = float.Parse(values[quantityIndex]);

                    // Replace -1 with 0
                    if (quantity == -1)
                    {
                        quantity = 0;
                    }

                    wines.Add(new Wine(quantity));
                }

                return wines.ToArray();
            }
        }


        /// <summary>
        /// Counts the number of lines in a CSV file.
        /// </summary>
        /// <param name="filePath">The path to the CSV file.</param>
        /// <returns>The number of lines in the CSV file.</returns>
        static int CountLinesInCSV(string filePath)
        {
            try
            {
                int lineCount = 0;
                using (StreamReader reader = new StreamReader(filePath))
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
        public static Tank[] CSVToTank(string path, int size)
        {
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
                    var values = line.Split(',');

                    var tank = new Tank();
                    tank.Capacity = int.Parse(values[0]);

                    int wineIndex = int.Parse(values[1]);
                    tank.Wine = new Wine[size];
                    for (var j = 0; j < size; j++)
                    {
                        tank.Wine[j] = new Wine();
                        if (wineIndex > -1)
                            tank.Wine[j].Quantity = (j == wineIndex) ? tank.Capacity : 0;
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