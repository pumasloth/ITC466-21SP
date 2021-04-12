namespace HW4EX1Code
{
    /// <summary>
    /// The ComboOrderService interface.
    /// </summary>
    public interface IComboOrderService
    {
        /// <summary>
        /// The order combo.
        /// </summary>
        /// <param name="quantity">
        /// The quantity.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        bool OrderCombo(int quantity);
    }
}