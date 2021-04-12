namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The fake reserve inventory.
    /// </summary>
    public class FakeReserveInventory : IReserveInventory
    {
        /// <summary>
        /// The was called.
        /// </summary>
        public bool wasCalled = false;

        /// <summary>
        /// The reserve inventory.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool ReserveInventory(Cart cart)
        {
            this.wasCalled = true;

            return this.wasCalled;
        }
    }
}