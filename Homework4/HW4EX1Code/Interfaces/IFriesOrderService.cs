namespace HW4EX1Code
{
    /// <summary>
    /// The FriesOrderService interface.
    /// </summary>
    public interface IFriesOrderService
    {
        /// <summary>
        /// The order fries.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        bool OrderFries(int quantity);
    }
}