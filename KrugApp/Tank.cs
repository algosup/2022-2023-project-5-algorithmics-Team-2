using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace KrugApp
{
    public class Tank
    {
        public const int MIN_CAPACITY = 1;
        public const int MAX_CAPACITY = 10;

        public const int MAX_WINES = 400;
        public bool IsEmpty { get; set; }
        public List<Tuple<int, int>> Steps { get; set; }
            
        public int Capacity { get; set; }
        public Wine[] Wine { get; set; }
        public int Index { get; set; }

        //public int[][] Node { get; set; }

        /// <summary>
        /// Create a tank with a random capacity between 10 and 100
        /// </summary>
        public Tank(int index)
        {
            Random rnd = new Random();
            this.Capacity = rnd.Next(MIN_CAPACITY, MAX_CAPACITY);
            this.Wine = new Wine[MAX_WINES];
            this.Steps = new List<Tuple<int, int>>();
            for (int i = 0; i < MAX_WINES; i++)
                this.Wine[i] = new Wine();
            this.Index = index;
            this.IsEmpty = true;
        }

        public Tank()
        {
            new Tank(0);
        }

        public Tank(Wine[] wine)
        {
            new Tank(wine, 0);
        }

        /// <summary>
        /// create a tank with a define capacity
        /// </summary>
        /// <param name="capacity"></param>
        public Tank(int capacity, int index)
        {
            this.Capacity = capacity;
            this.Wine = new Wine[MAX_WINES];
            for (int i = 0; i < MAX_WINES; i++)
                this.Wine[i] = new Wine();
            this.Index = index;
            this.Steps = new List<Tuple<int, int>>();
            this.IsEmpty = true;
        }

        /// <summary>
        /// Return the total quantity of a tank, that have multiple wines in it.
        /// </summary>
        /// <param name="total"> Array of the wines' capacity</param>
        public Tank(Wine[] total, int index)
        {
            if(total.Length == MAX_WINES)
            {
                if (total.Sum(wine => wine.Quantity) > MAX_CAPACITY)
                    throw new Exception("The total quantity of wine is too big for the tank.");
                else if (total.Sum(wine => wine.Quantity) < MIN_CAPACITY)
                    throw new Exception("The total quantity of wine is too small for the tank.");
                this.Capacity = (int)total.Sum(wine => wine.Quantity);
                this.Wine = total;
                this.Index = index;
                this.Steps = new List<Tuple<int, int>>();
                this.IsEmpty = false;
            }
            else
            {
                throw new Exception("Invalide number of wines");
            }
        }

        /// <summary>
        /// Fill the tank with only one wine
        /// </summary>
        /// <param name="indexOfWine">The index of where the wine is</param>
        public void FillWithOneWine(int indexOfWine)
        {
            if (this.Wine.Sum(wine => wine.Quantity) == 0)
            {
                this.Wine[indexOfWine].Quantity = this.Capacity;
                this.IsEmpty = false;
            }
            else
                throw new Exception("Cannot fill a full tank.");
        }

        /*
        /// <summary>
        /// Transfers the total quantity of wines from an array of tanks into a new tank.
        /// </summary>
        /// <param name="tanks">The array of tanks to transfer from.</param>
        /// <returns>A new tank with the combined capacity and quantity from the input tanks.</returns>
       

        /// <summary>
        /// Return an array of tanks with the wine from the target tank.
        /// </summary>
        /// <param name="tanks">Array of tanks to transfer wine from</param>
        /// <param name="tank">Target tank to receive the transferred wine</param>
        /// <returns>An array of tanks with transferred quantities</returns>
        /// <remarks>The tank receivers need to be empty, and their total capacity needs to be equal to the capacity of the initial tank.</remarks>
        */

        /// <summary>
        /// Calculates the percentages of the total capacity for each tank in the provided array.
        /// </summary>
        /// <param name="tanks">The array of tanks.</param>
        /// <returns>An array of tanks with the calculated percentages.</returns>
        public Tank[] CalculatePercentages(Tank[] tanks)
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

        public static Tank[] splitTanks(Tank tankInput, Tank[] tanks)
        {
            if (tankInput.Capacity != tanks.Sum(tank => tank.Capacity))
            {
                throw new Exception("The total capacity of the tanks is not equal to the capacity of the target tank." + tanks.Sum(tank => tank.Capacity) + "=/=" + tankInput.Capacity);
            }

            foreach(Tank tank in tanks)
                if (tank.Wine.Sum(wine => wine.Quantity) != 0)
                    throw new Exception("Cannot transfer if the total quantity of wine in the output tanks is not zero.");

            var res = new Tank[tanks.Length];
            
            for (int i = 0; i < tanks.Length; i++)
            {
                res[i] = (tankInput * tanks[1].Capacity) / tankInput.Capacity;
                res[i].Index = tanks[i].Index;
                res[i].IsEmpty = false;
            }
            
            return res;
        }

        /// <summary>
        /// Adds two tanks together, combining their capacity and wine quantities.
        /// </summary>
        /// <param name="tank1">The first tank.</param>
        /// <param name="tank2">The second tank.</param>
        /// <returns>A new tank with the combined capacity and wine quantities.</returns>
        /// <remarks>If the total quantity of wines is higer or lower than the capacity of the tank, it will return an erro</remarks>
        public static Tank operator +(Tank tank1, Tank tank2)
        {
            Tank tank = new Tank(tank1.Capacity + tank2.Capacity, 0);

            for (int i = 0; i < tank.Wine.Length; i++)
                tank.Wine[i] = tank1.Wine[i] + tank2.Wine[i];

            tank.IsEmpty = false;

            if (tank.Capacity == tank.Wine.Sum(tank => tank.Quantity) || tank.Wine.Sum(tank => tank.Quantity) == 0)
                return tank;
            else
                throw new Exception("The tank is neither full nor empty.");

        }

        public static Tank operator /(Tank tank, int divider)
        {
            if (divider == 0)
                throw new DivideByZeroException();

            Tank res = new Tank(tank.Capacity / divider);
            for (int i = 0; i < res.Wine.Length; i++)
            {
                res.Wine[i].Quantity = tank.Wine[i].Quantity / divider;
            }
            return res;
        }

        public static Tank operator *(Tank tank, int multiplier)
        {
            Tank res = new Tank(tank.Capacity * multiplier);

            for (int i = 0; i < res.Wine.Length; i++)
            {
                res.Wine[i].Quantity = tank.Wine[i].Quantity * multiplier;
            }
            return res;
        }

        public void GenrerateCombinaison(Tank[] tanks)
        {
            for(int i = 0; i < tanks.Length - 1; i++)
            {
                if (i == this.Index) continue;
                for(int j = i + 1; j < tanks.Length; j++)
                {
                    if (j == this.Index) continue;
                    if (tanks[i].Capacity + tanks[j].Capacity == this.Capacity)
                    {
                        this.Steps.Add( new Tuple<int,int>(i, j) );
                    }
                }
            }
        }


        private void empty()
        {
            foreach (Wine wine in this.Wine)
            {
                wine.Quantity = 0;
            }
            this.IsEmpty = true;
        }


        public static Tank[] getStateAfterStep(Tank[] currentState, Tuple<int?, Tuple<int, int>, int?> step)
        {
            if (step.Item1 != null) // (source => (target1 , target 2))
            {
                if (!currentState[step.Item1.Value].IsEmpty && currentState[step.Item2.Item1].IsEmpty && currentState[step.Item2.Item2].IsEmpty)
                {
                var split = splitTanks(currentState[step.Item1.Value], new Tank[] { currentState[step.Item2.Item1], currentState[step.Item2.Item2] });
                currentState[step.Item2.Item1] = split[0];
                currentState[step.Item2.Item2] = split[1];
                currentState[step.Item1.Value].empty();
                }
            }
            else // ((source1, source2) => target)
            {
                if (step.Item3 == null) // impossible case
                    throw new Exception("Not supposed to be null.");

                if (currentState[step.Item3.Value].IsEmpty && !currentState[step.Item2.Item1].IsEmpty && !currentState[step.Item2.Item2].IsEmpty) // Fill the tank only if it is empty
                {
                    var tmp = currentState[step.Item2.Item1] + currentState[step.Item2.Item2];
                    tmp.Index = currentState[step.Item3.Value].Index;
                    if (tmp.Capacity == currentState[step.Item3.Value].Capacity)
                    {
                        currentState[step.Item3.Value] = tmp;
                        currentState[step.Item2.Item1].empty();
                        currentState[step.Item2.Item2].empty();
                    }
                    else
                    {
                        throw new Exception("Invalid step : \n"+
                            "(("+step.Item2.Item1+"."+step.Item2.Item2+")=>"+step.Item3+")"+" .\n" +
                            "((" + currentState[step.Item2.Item1].Capacity + "." + currentState[step.Item2.Item2].Capacity + ")=>" + currentState[step.Item3.Value].Capacity + ")" + " .\n" +
                            "Tank at index " + step.Item3.Value + " or " + tmp.Index + "has capacity of " + tmp.Capacity + " or " + currentState[step.Item3.Value].Capacity + ".\n" +
                            "The capacity of the tank should be equal to the sum of the capacities of the two tanks.\n" +
                            "The capacities of the tanks are " + currentState[step.Item2.Item1].Capacity + " and " + currentState[step.Item2.Item2].Capacity + ".\n");
                    }
                }
                else
                {
                    // skip the step
                    //throw new Exception("The tank is not empty.");
                }
            }
            return currentState;
        }
    }
}
