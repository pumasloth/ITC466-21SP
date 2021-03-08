namespace HW3EX1B4.Services
{
    using System;
    using HW3EX1B4.Exceptions;
    using HW3EX1B4.Model;

    /// <summary>
    /// The inventory system class.
    /// </summary>
    public class InventorySystem
    {
        public static void Reserve(string sku, int quantity)
        {
            throw new InsufficientInventoryException();
        }

        /// <summary>
        /// Reserve an item from inventory.
        /// </summary>
        /// <param name="cart">The <see cref="Cart"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when cart is null.
        /// </exception>
        /// <exception cref="OrderException">
        /// Thrown when there's insufficient inventory.
        /// </exception>
        public static void ReserveInventory(Cart cart)
        {
            if (cart == null)
            {
                throw new ArgumentNullException(nameof(cart));
            }

            foreach (var item in cart.Items)
            {
                try
                {
                    Reserve(item.Sku, item.Quantity);
                }
                catch (InsufficientInventoryException ex)
                {
                    throw new OrderException("Insufficient inventory for item " + item.Sku, ex);
                }
                catch (Exception ex)
                {
                    throw new OrderException("Problem reserving inventory", ex);
                }
            }
        }
    }
}