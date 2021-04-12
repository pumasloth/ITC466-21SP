namespace HW4EX1Code
{
    using System;

    /// <summary>
    /// The fries order service.
    /// </summary>
    public class FriesOrderService : IFriesOrderService
    {
        /// <summary>
        /// The order fries.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool OrderFries(int quantity)
        {
            Console.WriteLine($"Added {quantity} fries to the order");
            return true;
        }
    }
}