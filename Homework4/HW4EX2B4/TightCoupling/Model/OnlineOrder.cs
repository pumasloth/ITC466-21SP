namespace HW4EX2B4.TightCoupling.Model
{
    using HW4EX2B4.TightCoupling.Services;
    using HW4EX2B4.Utility;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The online order.
    /// </summary>
    public class OnlineOrder : Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnlineOrder"/> class.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        public OnlineOrder(Cart cart)
            : base(cart)
        {
        }

        /// <summary>
        /// Checkout a cart.
        /// </summary>
        /// <param name="cart">
        /// The <see cref="Cart"/>.
        /// </param>
        /// <param name="paymentDetails">
        /// The <see cref="PaymentDetails"/>.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool Checkout(Cart cart, PaymentDetails paymentDetails)
        {
            var wasCalled = true;

            var serviceProvider = Startup.ConfigureService();
            var paymentGateway = serviceProvider.GetRequiredService<PaymentGateway>();
            var inventorySystem = serviceProvider.GetRequiredService<InventorySystem>();
            var notifyCustomerService = serviceProvider.GetRequiredService<NotifyCustomerService>();

            paymentGateway.Charge();

            foreach (var item in cart.Items)
            {
                inventorySystem.Reserve(item.Sku, item.Quantity);
            }

            notifyCustomerService.NotifyCustomer(cart);

            return wasCalled;
        }
    }
}
