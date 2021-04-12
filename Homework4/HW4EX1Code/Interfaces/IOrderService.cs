namespace HW4EX1Code
{
    /// <summary>
    /// The Order interface.
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// The submit order.
        /// </summary>
        /// <param name="order">
        /// The order.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        bool SubmitOrder(object order);
    }
}