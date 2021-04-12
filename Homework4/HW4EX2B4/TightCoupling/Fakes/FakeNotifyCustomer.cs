namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The fake notify customer.
    /// </summary>
    public class FakeNotifyCustomer : INotifyCustomer
    {
        /// <summary>
        /// The was called.
        /// </summary>
        public bool wasCalled = false;

        /// <summary>
        /// The notify customer.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        public bool NotifyCustomer(Cart cart)
        {
            this.wasCalled = true;

            return this.wasCalled;
        }
    }
}