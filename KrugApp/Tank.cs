using System;
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
            int num = rnd.Next(10, 100);
            this.Capacity = num;
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
        /// <remarks>
        /// This function clears the contents of the array by setting all elements to their default values.
        /// After calling this function, the array will still have the same length, but all elements will
        /// be reset to their default values (e.g., 0 for numeric types, null for reference types).
        /// </remarks>
        public static void EmptyArray<T>(Wine[] array)
        {
            Array.Clear(array, 0, array.Length);
        }


        /// <summary>
        /// Adds two tanks together, combining their capacity and wine quantities.
        /// </summary>
        /// <param name="tank1">The first tank.</param>
        /// <param name="tank2">The second tank.</param>
        /// <returns>A new tank with the combined capacity and wine quantities.</returns>
        public static Tank operator +(Tank tank1, Tank tank2)
        {
            Tank tank = new Tank(tank1.Capacity + tank2.Capacity);

            for (int i = 0; i < tank.Wine.Length; i++)
            {
                tank.Wine[i] = tank1.Wine[i] + tank2.Wine[i];
            }

            return tank;
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

            return new Tank(totalWines)
            {
                Capacity = totalCapacity
            };

        }

        //Need to be done

        /// <summary>
        /// Transfers the contents of the current tank to another tank.
        /// </summary>
        /// <param name="otherTank">The tank to transfer the contents to.</param>
        public void TransferTo(Tank otherTank)
        {
            // Transfer the capacity
            otherTank.Capacity += Capacity;

            // Transfer the wines
            for (int i = 0; i < MAX_WINES; i++)
            {
                otherTank.Wine[i].Quantity += Wine[i].Quantity;
            }
        }

        /// <summary>
        /// Calculates the percentages of the total capacity for each tank in the provided array.
        /// </summary>
        /// <param name="tanks">The array of tanks.</param>
        /// <returns>An array of tanks with the calculated percentages.</returns>
        public static Tank[] CalculatePercentages(Tank[] tanks)
        {
            float total = tanks.Sum(tank => tank.Capacity);

            return tanks.Select(tank => new Tank(tank.Capacity / total * 100)).ToArray();
        }


        //- fonction pour retourner la similarité du mélange avec le voulu



        //- Surcharge d operateur + pour ajouter 2 tanks ou plus



    }
}

