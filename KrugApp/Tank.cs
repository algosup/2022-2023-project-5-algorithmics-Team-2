﻿using System;
using System.Threading.Tasks;

namespace KrugApp
{
    public class Tank
    {
        private int MAX_WINES = 400;
        public float Capacity { get; set; }
        public Wine[] Wine { get; set; }

        /// <summary>
        /// Create a tank with a random capacity between 10 and 100
        /// </summary>
        public Tank()
        {
            Random rnd = new Random();
            this.Capacity = rnd.Next(10, 100);
            this.Wine = new Wine[MAX_WINES];
        }

        /// <summary>
        /// create a tank with a define capacity
        /// </summary>
        /// <param name="capacity"></param>
        public Tank(float capacity)
        {
            this.Capacity = capacity;
            this.Wine = new Wine[MAX_WINES];
        }

        /// <summary>
        /// Return the total quantity of a tank, that have multiple wines in it.
        /// </summary>
        /// <param name="total"> Array of the wines' capacity</param>
        public Tank(Wine[] total)
        {
            this.Capacity = total.Sum(wine => wine.Quantity);
            this.Wine = new Wine[MAX_WINES];
        }

        /// <summary>
        /// Empties the contents of the specified array by setting all elements to their default values.
        /// </summary>
        /// <typeparam name="T">The type of elements in the array.</typeparam>
        /// <param name="array">The array to be emptied.</param>
        public static void EmptyTank<T>(Wine[] array)
        {
            Array.Clear(array, 0, array.Length);
        }


        /// <summary>
        /// Fill the tank with only one wine
        /// </summary>
        /// <param name="indexOfWine">The index of where the wine is</param>
        public void FillWithOneWine(int indexOfWine)
        {
            if (this.Wine.Sum(wine => wine.Quantity) == 0)
                this.Wine[indexOfWine].Quantity = this.Capacity;
            else
                throw new Exception("Cannot fill a full tank.");
        }


        /// <summary>
        /// Transfers the total quantity of wines from an array of tanks into a new tank.
        /// </summary>
        /// <param name="tanks">The array of tanks to transfer from.</param>
        /// <returns>A new tank with the combined capacity and quantity from the input tanks.</returns>
        public Tank TankFrom(Tank[] tanks)
        {
            float totalCapacity = tanks.Sum(tank => tank.Capacity);
            Wine[] totalWines = new Wine[MAX_WINES];

            for (int i = 0; i < MAX_WINES; i++)
            {
                float totalQuantity = tanks.Sum(tank => tank.Wine[i].Quantity);
                totalWines[i] = new Wine(totalQuantity);
            }

            return new Tank(totalWines);
        }

        /// <summary>
        /// Return an array of tanks with the wine from the target tank.
        /// </summary>
        /// <param name="tanks">Array of tanks to transfer wine from</param>
        /// <param name="tank">Target tank to receive the transferred wine</param>
        /// <returns>An array of tanks with transferred quantities</returns>
        /// <remarks>The tank receivers need to be empty, and their total capacity needs to be equal to the capacity of the initial tank.</remarks>
        public static Tank[] TransferTo(Tank[] tanks, Tank tank)
        {
            if (tanks.Sum(t => t.Wine.Sum(w => w.Quantity)) != 0)
            {
                throw new Exception("Cannot transfer if the total quantity of wine in the tanks is not zero.");
            }

            if (tanks.Sum(t => t.Capacity) != tank.Capacity)
            {
                throw new Exception("Cannot transfer if the total capacity of the tanks is not equal to the capacity of the target tank.");
            }

            Tank[] res = new Tank[tanks.Length];

            for (int j = 0; j < tanks.Length; j++)
            {
                res[j] = new Tank(tanks[j].Capacity);

                for (int i = 0; i < tank.MAX_WINES; i++)
                {
                    res[j].Wine[i].Quantity = (tank.Wine[i].Quantity / tank.Capacity) * tanks[j].Capacity;
                }

            }
            return res;
        }



        /// <summary>
        /// Calculates the percentages of the total capacity for each tank in the provided array.
        /// </summary>
        /// <param name="tanks">The array of tanks.</param>
        /// <returns>An array of tanks with the calculated percentages.</returns>
        public Tank[] CalculatePercentages(Tank[] tanks)
        {
            float total = tanks.Sum(tank => tank.Capacity);

            return tanks.Select(tank => new Tank(tank.Capacity / total * 100)).ToArray();
        }

        /// <summary>
        /// Calculates the similarity between a given formula of wines and the quantities of wines in a set of tanks.
        /// </summary>
        /// <param name="formula">An array representing the desired quantities of wines in the final mix.</param>
        /// <param name="tanks">An array of tanks containing the current quantities of wines.</param>
        /// <returns>An array of wines representing the differences between the desired quantities and the tank quantities.</returns>
        public Wine[] CalculateSimilarity(Wine[] formula, Tank[] tanks)
        {
            Wine[] tank1 = tanks.SelectMany(tank => tank.Wine).ToArray();
            Wine[] diff = new Wine[formula.Length];

            for (int i = 0; i < formula.Length; i++)
            {
                diff[i] = new Wine(formula[i].Quantity - tank1[i].Quantity);
            }

            return diff;
        }

        // Operator overloads

        /// <summary>
        /// Adds two tanks together, combining their capacity and wine quantities.
        /// </summary>
        /// <param name="tank1">The first tank.</param>
        /// <param name="tank2">The second tank.</param>
        /// <returns>A new tank with the combined capacity and wine quantities.</returns>
        /// <remarks>If the total quantity of wines is higer or lower than the capacity of the tank, it will return an erro</remarks>
        public static Tank operator +(Tank tank1, Tank tank2)
        {
            Tank tank = new Tank(tank1.Capacity + tank2.Capacity);

            for (int i = 0; i < tank.Wine.Length; i++)
                tank.Wine[i] = tank1.Wine[i] + tank2.Wine[i];

            if (tank.Capacity == tank.Wine.Sum(tank => tank.Quantity) || tank.Wine.Sum(tank => tank.Quantity) == 0)
                return tank;
            else
                throw new Exception("The tank is neither full nor empty.");

        }


    }
}