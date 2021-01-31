namespace Homework1
{
    using System;

    /// <summary>
    /// The snack class.
    /// </summary>
    public class Snack : IPurchasable
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Display the price of the snack.
        /// </summary>
        public void Purchase()
        {
            Console.WriteLine($"Purchasing a snack for {this.Price.ToString("C0")}.");
        }
    }
}
