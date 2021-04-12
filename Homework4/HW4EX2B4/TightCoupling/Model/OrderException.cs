using System;

namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The order exception.
    /// </summary>
    public class OrderException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderException"/> class.
        /// </summary>
        /// <param name="message">
        /// The message.
        /// </param>
        /// <param name="innerException">
        /// The inner exception.
        /// </param>
        public OrderException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}