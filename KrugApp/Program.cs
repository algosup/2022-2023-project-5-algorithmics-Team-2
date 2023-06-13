using System;
using System.ComponentModel.Design;
using System.Linq;
using KrugApp;

namespace KrugApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Tank[] tanks = new Tank[330];
            Random random = new Random();
            for (int i = 0; i < tanks.Length; i++)
                tanks[i] = new Tank(random.Next(10,100));



            var combinaison = new List<Tuple<int, int>>[tanks.Length];
            for (int i = 0; i < tanks.Length; i++)
                combinaison[i] = Tank.GenerateCombinaison(tanks[i], tanks);


            for (int i = 0; i < 15; i++)
                tanks[i].FillWithOneWine(i);

            TankTree tankTree = new TankTree(tanks);

            tankTree.GenerateChilds(4, combinaison);

            //var a = tankTree.ChildNodes.First().ChildNodes.First().value[0];

            Console.WriteLine("\n\tDone" + tankTree.ChildNodes.Count);
        }
    }
}
