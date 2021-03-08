namespace HW3EX1B4.Services
{
    using System;
    using HW3EX1B4.Model;
    using HW3EX1B4.Utility;

    public class NotificationService
    {
        /// <summary>
        /// Notify the customer of their cart.
        /// </summary>
        /// <param name="cart">The customer's <see cref="Cart"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when cart or cart.CustomerEmail is null.
        /// </exception>
        public static void NotifyCustomer(Cart cart)
        {
            if (cart == null)
            {
                throw new ArgumentNullException(nameof(cart));
            }

            string customerEmail = cart.CustomerEmail;
            if (!string.IsNullOrEmpty(customerEmail))
            {
                EmailUtility.SendEmail(customerEmail, cart);
            }
            else
            {
                throw new ArgumentNullException(nameof(customerEmail));
            }
        }
    }
}
