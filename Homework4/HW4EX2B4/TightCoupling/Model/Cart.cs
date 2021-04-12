using System.Collections.Generic;

namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The cart.
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

        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        /// <param name="orderItems">
        /// The order items.
        /// </param>
        public Cart(List<OrderItem> orderItems)
        {
            this.Items = orderItems;
        }
    }
}