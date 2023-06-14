using System.Diagnostics;

namespace KrugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            // Will be changed to a user input
            Tank[] tanks = new Tank[20];
            Random random = new Random();
            for (int i = 0; i < tanks.Length; i++)
                tanks[i] = new Tank(random.Next(1,10));

            // Will be changed to a user input
            Wine[] formula = new Wine[Tank.MAX_WINES];

            // Will be changed to a user input
            for (int i = 0; i < 5; i++)
                tanks[i].FillWithOneWine(i);

            // Generate all possible combinaisons (ligther than storing them in each tank of each node)
            var combinaison = new List<Tuple<int, int>>[tanks.Length];
            for (int i = 0; i < tanks.Length; i++)
                combinaison[i] = Tank.GenerateCombinaison(tanks[i], tanks);

            // Create the root node
            TankTree tankTree = new TankTree(tanks);

            var a = new TankTree((Tank[])tanks.Clone());
            // Create the tree with a depth defined by the programmer
            tankTree.GenerateChilds(4, combinaison);

            //TODO Breadth search for the best solution
            /*TankTree? solutionNode = tankTree.BreadthSearch(formula);
            //TODO Breadth search for the best solution

            // Print the solution
            Console.WriteLine("\n\tSolution:");
            while (solutionNode != null)
            {
                Console.WriteLine(solutionNode.Step);
                solutionNode = solutionNode.ParentNode;
            }*/

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
            ts.Hours, ts.Minutes, ts.Seconds,
            ts.Milliseconds / 10);
            Console.WriteLine("RunTime " + elapsedTime);

            Console.WriteLine("\n\tDone \t" + tankTree.ChildNodes.Count);
           Console.WriteLine();
        }
    }
}
