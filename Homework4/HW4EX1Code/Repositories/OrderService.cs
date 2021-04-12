namespace HW4EX1Code
{
    using System;

    /// <summary>
    /// The order service.
    /// </summary>
    public class OrderService : IOrderService
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
        public bool SubmitOrder(object order)
        {
            Console.WriteLine($"Submitted order {order}");
            return true;
        }
    }
}
