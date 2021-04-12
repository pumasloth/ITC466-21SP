namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The order.
    /// </summary>
    public abstract class Order
    {
        /// <summary>
        /// The _cart.
        /// </summary>
        protected readonly Cart _cart;

        /*
            Dependency Inversion Principle
         *  High-level modules should not depend on low-level modules. Both should depend on abstractions. 
            Abstractions should not depend on details. Details should depend on abstractions
         */

        /// <summary>
        /// Initializes a new instance of the <see cref="Order"/> class.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        protected Order(Cart cart)
        {
            this._cart = cart;
        }

        /// <summary>
        /// The checkout.
        /// </summary>
        /// <returns>
        /// True when called.
        /// </returns>
        public virtual bool Checkout()
        {
            var wasCalled = true;
            return wasCalled;
        }
    }
}

