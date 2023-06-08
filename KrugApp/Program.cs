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
            for (int i = 0; i < tanks.Length; i++)
                tanks[i] = new Tank(i);


            for(int i = 0; i < 5; i++)
            {
                tanks[i].FillWithOneWine(i);
                tanks[i].IsEmpty = false;
            }



            for (int i = 0; i < tanks.Length; i++)
            {
                tanks[i].GenrerateCombinaison(tanks);
            }

            TankTree tankTree = new TankTree(tanks);

            tankTree.GenerateChilds(4);

            var a = tankTree.ChildNodes.First().ChildNodes.First().value[0];

            Console.WriteLine("\n\tDone" + a.Capacity);
        }
    }
}
