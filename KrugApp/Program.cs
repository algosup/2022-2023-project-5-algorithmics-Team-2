using System.Collections.Generic;
using System.Diagnostics;

namespace KrugApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No arguments given\nWrite --help or -h for help");
                Console.ResetColor();
                return;
            }

            if (args[0] == "--help" || args[0] == "-h")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("First argument is the path to formula\n" +
                                  "Second argument is the path to the tanks\n" +
                                  "For example : \"./Folder/To/File.csv\"");
                Console.ResetColor();
                return;
            }

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            Wine[] formula = Utility.CSVToFormula(args[0]);

            Console.WriteLine(formula.Length);

            List<Tank> myTankList = new List<Tank>();

            foreach (var tank in Utility.CSVToTanks(args[1], Tank.MAX_WINES))
            {
                if (tank == null)
                {
                    continue;
                }
                myTankList.Add(tank);
            }

            Tank[] tanks = myTankList.ToArray();

            // possibility of transfert

            TankTree tree = new TankTree(tanks);
            var combinaison = new List<Tuple<int, int>>[tanks.Length];


            for (int i = 0; i < tanks.Length; i++)
            {
                combinaison[i] = (Tank.GenerateCombinaison(tanks[i], tanks));
            }

            int depth = 5;

            tree.GenerateChilds(depth, combinaison);

            Console.WriteLine($"amount of nodes at depth {depth} : {tree.CountNodes()}");

            var bestNode = TankTree.Search(tree, formula);

            Console.ForegroundColor = ConsoleColor.Green;
            var tmpNode = bestNode;
            while (tmpNode.ParentNode != null)
            {
                if (tmpNode.Step.Item1 != null)
                    Console.WriteLine($"Split tank number {tmpNode.Step.Item1} into tanks {tmpNode.Step.Item2.Item1} and {tmpNode.Step.Item2.Item2}");
                else
                    Console.WriteLine($"Merge into tank number {tmpNode.Step.Item3} tanks {tmpNode.Step.Item2.Item1} and {tmpNode.Step.Item2.Item2}");
                tmpNode = tmpNode.ParentNode;
            }
            // Print the closest tank to the formula from the best node
            Tank best = TankTree.bestTank(bestNode, formula);

            Console.WriteLine("\tTank : ");
            foreach(var wine in best.Wine)
            {
                Console.Write(wine.Quantity + " ");
            }

            Console.WriteLine("\n\tFormula : ");
            foreach (var wine in formula)
            {
                Console.Write(wine.Quantity + " ");
            }

            Console.ResetColor();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nTime elapsed: " + ts.TotalSeconds + " seconds");
        }
    }
}

