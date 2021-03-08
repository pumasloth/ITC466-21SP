namespace HW3EX1B4.Model
{
    using System.Collections.Generic;

    /// <summary>
    /// The cart class.
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// Gets or sets the total amount.
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        public IEnumerable<OrderItem> Items { get; set; }

        /// <summary>
        /// Gets or sets the customer email.
        /// </summary>
        public string CustomerEmail { get; set; }
    }
}