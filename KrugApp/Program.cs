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

            var tmpNode = bestNode;
            while (tmpNode.ParentNode != null)
            {
                if (tmpNode.Step.Item1 != null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Split ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("tank number ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" into tanks ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item2.Item1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" and ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item2.Item2 + "\n");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Merge ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("into tank number ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item3);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" tanks ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item2.Item1);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" and ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(tmpNode.Step.Item2.Item2 + "\n");

                }
                Console.ResetColor();
                tmpNode = tmpNode.ParentNode;
            }
            // Print the closest tank to the formula from the best node
            Tank best = TankTree.bestTank(bestNode, formula);

            Console.WriteLine("Tank :\tFormula :");
            for (int i = 0; i < formula.Length || i < best.Wine.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                if (best.Wine[i].Quantity != 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(best.Wine[i].Quantity + "\t");
                Console.ForegroundColor = ConsoleColor.White;
                if (formula[i].Quantity != 0)
                    Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(formula[i].Quantity + "\n");
            }

            Console.ResetColor();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.WriteLine("\nTime elapsed: " + ts.TotalSeconds + " seconds");
        }
    }
}

