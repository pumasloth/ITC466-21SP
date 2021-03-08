namespace HW3EX1B4.Model
{
    using System;
    using HW3EX1B4.Services;

    /// <summary>
    /// The credit card order class.
    /// Point of Sale (POS) transactions don’t need inventory reservations.
    /// POS transactions don’t need email notifications.
    /// </summary>
    public class CreditCardOrder : Order
    {
        /// <summary>
        /// Checkout a cart.
        /// </summary>
        /// <param name="cart">The <see cref="Cart"/>.</param>
        /// <param name="paymentDetails">The <see cref="PaymentDetails"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when cart or paymentDetails is null.
        /// </exception>
        public void Checkout(Cart cart, PaymentDetails paymentDetails)
        {
            if (cart == null)
            {
                throw new ArgumentNullException(nameof(cart));
            }

            if (paymentDetails == null)
            {
                throw new ArgumentNullException(nameof(paymentDetails));
            }

            PaymentGateway.ChargeCard(paymentDetails, cart);
        }
    }
}
