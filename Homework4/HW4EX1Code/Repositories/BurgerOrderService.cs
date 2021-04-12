namespace HW4EX1Code
{
    using System;

    /// <summary>
    /// The burger order service.
    /// </summary>
    public class BurgerOrderService : IBurgerOrderService
    {
        /// <summary>
        /// The order burger.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool OrderBurger(int quantity)
        {
            Console.WriteLine($"Added {quantity} burgers to the order");
            return true;
        }
    }
}