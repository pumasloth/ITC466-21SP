namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The ReserveInventory interface.
    /// </summary>
    public interface IReserveInventory
    {
        /// <summary>
        /// The reserve inventory.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        bool ReserveInventory(Cart cart);
    }
}