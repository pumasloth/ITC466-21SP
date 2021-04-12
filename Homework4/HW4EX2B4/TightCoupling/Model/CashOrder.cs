namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The cash sales.
    /// </summary>
    public class CashOrder : Order
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CashOrder"/> class.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        public CashOrder(Cart cart)
            : base(cart)
        {

        }

        /// <summary>
        /// The checkout.
        /// </summary>
        /// <returns>
        /// True when called.
        /// </returns>
        public override bool Checkout()
        {
            var wasCalled = true;
            
            return wasCalled;
        }
    }
}