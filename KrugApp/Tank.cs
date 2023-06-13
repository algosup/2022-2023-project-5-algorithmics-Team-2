﻿using System;
using System.Collections;
using System.Threading.Tasks;

namespace KrugApp
{
    public class Tank
    {
        public const int MIN_CAPACITY = 1;
        public const int MAX_CAPACITY = 200;

        public const int MAX_WINES = 4;

        public int Capacity { get; set; }
        public Wine[] Wine { get; set; }
        //public int[][] Node { get; set; }

        /// <summary>
        /// Creates a tank with a random capacity between 10 and 100
        /// </summary>
        public Tank()
        {
            Random rnd = new Random();
            this.Capacity = rnd.Next(MIN_CAPACITY, MAX_CAPACITY);
            this.Wine = new Wine[MAX_WINES];
            for (int i = 0; i < MAX_WINES; i++)
                this.Wine[i] = new Wine();
        }

        /// <summary>
        /// Creates a tank with a define capacity
        /// </summary>
        /// <param name="capacity">The capacity of the tank.</param>
        public Tank(int capacity)
        {
            if (capacity < MIN_CAPACITY || capacity > MAX_CAPACITY)
                throw new ArgumentException($"Capacity must be between {MIN_CAPACITY} and {MAX_CAPACITY}");
            this.Capacity = capacity;
            this.Wine = new Wine[MAX_WINES];
            for (int i = 0; i < MAX_WINES; i++)
                this.Wine[i] = new Wine();
        }

        /// <summary>
        /// Creates a tank with a specified amount of wine at a given index.
        /// </summary>
        /// <param name="wine">The amount of wine to be stored.</param>
        /// <param name="index">The index of the wine in the tank.</param>
        public Tank(float wine, int index)
        {
            this.Capacity = (int)wine;
            this.Wine = new Wine[MAX_WINES];
            for (int i = 0; i < MAX_WINES; i++)
                this.Wine[i] = new Wine();

            this.Wine[index].Quantity = wine;
        }

        /// <summary>
        /// Returns the total quantity of a tank, that have multiple wines in it.
        /// </summary>
        /// <param name="total"> Array of the wines' capacity.</param>
        public Tank(Wine[] total)
        {
            if (total.Sum(wine => wine.Quantity) == 0)
            {
                throw new Exception("The total quantity of wine is too small for the tank.");
            }

            if(total.Length == MAX_WINES)
            {
                if (total.Sum(wine => wine.Quantity) > MAX_CAPACITY)
                    throw new Exception("The total quantity of wine is too big for the tank.");
                else if (total.Sum(wine => wine.Quantity) < MIN_CAPACITY)
                    throw new Exception("The total quantity of wine is too small for the tank.");
                this.Capacity = (int)total.Sum(wine => wine.Quantity);
                this.Wine = total;
            }
            else
            {
                throw new Exception("Invalide number of wines");
            }
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
        /// Fill the tank with only one wine.
        /// </summary>
        /// <param name="indexOfWine">The index of where the wine is.</param>
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
        public static Tank TankFrom(Tank[] tanks)
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
        /// <param name="tanks">Array of tanks to transfer wine from.</param>
        /// <param name="tank">Target tank to receive the transferred wine.</param>
        /// <returns>An array of tanks with transferred quantities.</returns>
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

                for (int i = 0; i < Tank.MAX_WINES; i++)
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
        public static Tank[] CalculatePercentages(Tank[] tanks)
        {
            float total = tanks.Sum(tank => tank.Capacity);

            return tanks.Select(tank => new Tank((int)(tank.Capacity / total * 100))).ToArray();
        }

        /// <summary>
        /// Calculates the similarity between a given formula of wines and the quantities of wines in a set of tanks.
        /// </summary>
        /// <param name="formula">An array representing the desired quantities of wines in the final mix.</param>
        /// <param name="tanks">An array of tanks containing the current quantities of wines.</param>
        /// <returns>An array of wines representing the differences between the desired quantities and the tank quantities.</returns>
        public static Wine[] CalculateSimilarity(Wine[] formula, Tank[] tanks)
        {
            Wine[] diff = new Wine[formula.Length];
        
            for (int i = 0; i < formula.Length; i++)
            {
                int quantityDifference = (int)(tanks[i].Capacity - formula[i].Quantity);
                diff[i] = new Wine(quantityDifference);
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
        /// <remarks>If the total quantity of wines is higer or lower than the capacity of the tank, it will return an error.</remarks>
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

        public static List<int[]> GenerateSumCombinations(Tank[] values)
        {
            List<int[]> result = new List<int[]>();
        
            for (int i = 0; i < values.Length; i++)
            {
                int[] combination = new int[values.Length];
                GenerateSumCombinations(values, values[i].Capacity, combination, result, i, 0);
            }
        
            return result;
        }
        
        private static void GenerateSumCombinations(Tank[] values, int remainingCapacity, int[] combination, List<int[]> result, int currentIndex, int currentTankIndex)
        {
            if (remainingCapacity == 0)
            {
                // We have reached the desired sum, add the combination to the result
                result.Add((int[])combination.Clone());
                return;
            }

            if (currentTankIndex >= values.Length || remainingCapacity < 0 || currentIndex >= combination.Length)
            {
                // We have exhausted all tanks, exceeded the remaining capacity, or filled the combination array, backtrack
                return;
            }

            // Skip the current tank and move to the next one
            GenerateSumCombinations(values, remainingCapacity, combination, result, currentIndex, currentTankIndex + 1);

            // Try using the current tank if it doesn't exceed remaining capacity
            if (values[currentTankIndex].Capacity <= remainingCapacity)
            {
                combination[currentIndex] = values[currentTankIndex].Capacity;
                GenerateSumCombinations(values, remainingCapacity - values[currentTankIndex].Capacity, combination, result, currentIndex + 1, currentTankIndex);
                combination[currentIndex] = 0; // Reset the value to 0 for backtracking

                // Move to the next tank with the same remaining capacity
                GenerateSumCombinations(values, remainingCapacity, combination, result, currentIndex, currentTankIndex + 1);
            }
        }

        ///<summary>
        /// Traverse the nodes of the tree
        ///</summary>
        public Wine[] TraverseNodes(Wine[] nodes)
        {
            Wine[] copiedNodes = new Wine[nodes.Length];
            Array.Copy(nodes, copiedNodes, nodes.Length);

            for (int i = 0; i < copiedNodes.Length; i++)
            {
                Wine currentNode = copiedNodes[i];

                currentNode.Quantity = Tank.MAX_WINES - currentNode.Quantity + 1;
            }

            return copiedNodes;
        }

       public static bool CheckFormula(Tank[] table, Wine[] formula, float a)
        {
            int i = 0;
            var res = false;
            float c = 0;
           
            foreach (var tanks in table)
            {
                foreach (var wine in tanks.Wine)
                {
                    if (i < formula.Length && i < tanks.Wine.Length)
                    {
                        c = Math.Abs(formula[i].Quantity - tanks.Wine[i].Quantity);

                            if (c > a)
                            {
                                res = false;
                            break;
                            }
                            if (c <= a)
                            {
                                res = true;
                            }
                    
                    }
                    i++;
                }
            }
            return res;
        }
    }
}
