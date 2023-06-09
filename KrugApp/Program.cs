using System;
using System.Linq;
using KrugApp;

using System.Data;
using System.Data.OleDb;
using System.Globalization;
using System.IO;

namespace KrugApp
{
    public class Program
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

            Tank[] tankArrayA = new Tank[]
            {
                new Tank(100),
                new Tank(new Wine[] { new Wine(70), new Wine(40), new Wine(0), new Wine(1) }),
                //new Tank(100),
                new Tank(100),
                //new Tank(new Wine[] { new Wine(8), new Wine(41), new Wine(28), new Wine(3) }),
                //new Tank(new Wine[] { new Wine(0), new Wine(71), new Wine(5), new Wine(9) })
            };

            Tank[] tankArrayB = new Tank[]
            {
                //new Tank(new Wine[] { new Wine(0), new Wine(71), new Wine(5), new Wine(9) }),
                new Tank(new Wine[] { new Wine(0), new Wine(0), new Wine(120), new Wine(60) }),
                new Tank(100),
                //new Tank(new Wine[] { new Wine(60), new Wine(0), new Wine(0), new Wine(0) }),
                new Tank(new Wine[] { new Wine(8), new Wine(41), new Wine(28), new Wine(3) }),
                //new Tank(new Wine[] { new Wine(1), new Wine(4), new Wine(0), new Wine(90) }),
            };

            Console.WriteLine("Similarity of the nodes: " + Similarity(tankArrayA, tankArrayB) + " / 10");


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

        static int SimiPoint(int c, int d)
        {
            if (c == d)
                return 2;
            else if (c > d && c / 2 > d)
                return 1;
            else if (c < d && c > d / 2)
                return 1;
            else
                return 0;
        }

        static int NbrWines(Tank[] a)
        {
            var d = 0; // number of wines
            for (var i = 0; i < a.Length; i++)
                for (var j = 0; j < a[i].Wine.Length; j++)
                    if ((int)a[i].Wine[j].Quantity > 0)
                        d += 1;
            return d;
        }

        static int NbrTank(Tank[] a)
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

        static int NbrTotalWine(Tank[] a)
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

        static int NbrEachWine(Tank[] a, Tank[] b)
        {
            var d = 0; // number of wines
            var nbrWinesA = NbrWines(a); // Get the number of wines in array a

            if (nbrWinesA == 0)
                return 0; // Return 0 if there are no wines in array a to avoid division by zero

            for (var i = 0; i < a.Length; i++)
            {
                for (var j = 0; j < a[i].Wine.Length; j++)
                {
                    var tankA = a[i].Wine[j].Quantity;
                    var tankB = b[i].Wine[j].Quantity;
                    if (tankA == tankB)
                        d += 2;
                    else if (tankA > tankB && tankA / 2 >= tankB)
                        d += 1;
                    else if (tankA < tankB && tankA >= tankB / 2)
                        d += 1;
                }
            }

            d = d / nbrWinesA / 2;
            return d;
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
            foreach (var column1 in wine_name)
            {
                Console.WriteLine(column1);
            }
            foreach (var column2 in quantity)
            {
                Console.WriteLine(column2);
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
