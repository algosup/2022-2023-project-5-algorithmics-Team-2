using System;

namespace KrugApp
{
    public class Wine
    {
        public float Quantity { get; set; }

        /// <summary>
        /// Return the default quantity of wine, so 0
        /// </summary>
        public Wine()
        {
            this.Quantity = 0;
        }

        /// <summary>
        /// Create a Wine using the quantity 
        /// </summary>
        /// <param name="value"> the quantity of wine</param>
        public Wine(float value)
        {
            this.Quantity = value;
        }

        // Operator overloads
        public static Wine operator +(Wine wine1, Wine wine2)
        {
            return new Wine(wine1.Quantity + wine2.Quantity);
        }

        public static Wine operator -(Wine wine1, Wine wine2)
        {
            return new Wine(wine1.Quantity - wine2.Quantity);
        }

        public static Wine operator *(Wine wine1, Wine wine2)
        {
            return new Wine(wine1.Quantity * wine2.Quantity);
        }

        public static Wine operator /(Wine wine1, Wine wine2)
        {
            if (wine2.Quantity != 0)
                return new Wine(wine1.Quantity / wine2.Quantity);
            else
                throw new DivideByZeroException("Cannot divide by zero.");
        }

        public override string ToString()
        {
            return "Quantity: " + this.Quantity;
        }
    }
}
