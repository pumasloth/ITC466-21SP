using System;

namespace HW4EX2B4.TightCoupling.Model
{
    using HW4EX2B4.TightCoupling.Services;
    using HW4EX2B4.Utility;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The credit card order.
    /// </summary>
    public class CreditCardOrder : Order
    {

        public CreditCardOrder(Cart cart)
            : base(cart)
        {
        }

        /// <summary>
        /// Checkout a cart.
        /// </summary>
        /// <param name="cart">The <see cref="Cart"/>.</param>
        /// <param name="paymentDetails">The <see cref="PaymentDetails"/>.</param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool Checkout(Cart cart, PaymentDetails paymentDetails)
        {
            var wasCalled = true;
            var serviceProvider = Startup.ConfigureService();
            var paymentGateway = serviceProvider.GetRequiredService<PaymentGateway>();
            paymentGateway.Charge();
            
            return wasCalled;
        }
    }
}
