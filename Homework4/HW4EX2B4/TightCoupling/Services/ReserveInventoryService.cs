using System;
using HW4EX2B4.TightCoupling.Services;

namespace HW4EX2B4.TightCoupling.Model
{
    using HW4EX2B4.Utility;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The reserve inventory service.
    /// </summary>
    public class ReserveInventoryService : IReserveInventory
    {
        /// <summary>
        /// The reserve inventory.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        /// <exception cref="OrderException">
        /// Thrown when there's insufficient inventory.
        /// </exception>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool ReserveInventory(Cart cart)
        {
            var wasCalled = true;

            foreach (OrderItem item in cart.Items)
            {
                try
                {
                    var serviceProvider = Startup.ConfigureService();
                    var inventorySystem = serviceProvider.GetRequiredService<InventorySystem>();
                    inventorySystem.Reserve(item.Sku, item.Quantity);
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

            return wasCalled;
        }
    }
}