using System;

namespace HW4EX2B4.TightCoupling.Services
{
    /// <summary>
    /// The inventory system.
    /// </summary>
    public class InventorySystem
    {
        /// <summary>
        /// The reserve.
        /// </summary>
        /// <param name="sku">
        /// The sku.
        /// </param>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        public bool Reserve(string sku, int quantity)
        {
            var wasCalled = true;
            return wasCalled;
        }
    }

    /// <summary>
    /// The insufficient inventory exception.
    /// </summary>
    public class InsufficientInventoryException : Exception
    {
    }
}