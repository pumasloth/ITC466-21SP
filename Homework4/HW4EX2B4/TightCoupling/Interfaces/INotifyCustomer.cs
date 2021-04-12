namespace HW4EX2B4.TightCoupling.Model
{
    using System.Net.Mail;

    /// <summary>
    /// The NotifyCustomer interface.
    /// </summary>
    public interface INotifyCustomer
    {
        /// <summary>
        /// The notify customer.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        bool NotifyCustomer(Cart cart);
    }
}