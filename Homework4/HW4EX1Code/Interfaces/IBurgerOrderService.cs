namespace HW4EX1Code
{
    /// <summary>
    /// The BurgerOrderService interface.
    /// </summary>
    public interface IBurgerOrderService
    {
        /// <summary>
        /// The order burger.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        bool OrderBurger(int quantity);
    }
}