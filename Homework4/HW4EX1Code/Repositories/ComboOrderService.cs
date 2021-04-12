namespace HW4EX1Code
{
    using System;

    /// <summary>
    /// The combo order service.
    /// </summary>
    public class ComboOrderService : IComboOrderService
    {
        /// <summary>
        /// The order combo.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool OrderCombo(int quantity)
        {
            Console.WriteLine($"Added {quantity} combos to the order");
            return true;
        }
    }
}