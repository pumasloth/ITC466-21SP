namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The payment details.
    /// </summary>
    public class PaymentDetails
    {
        /// <summary>
        /// Gets or sets the payment method.
        /// </summary>
        public PaymentMethod PaymentMethod { get; set; }

        /// <summary>
        /// Gets or sets the credit card number.
        /// </summary>
        public string CreditCardNumber { get; set; }

        /// <summary>
        /// Gets or sets the expires month.
        /// </summary>
        public string ExpiresMonth { get; set; }

        /// <summary>
        /// Gets or sets the expires year.
        /// </summary>
        public string ExpiresYear { get; set; }

        /// <summary>
        /// Gets or sets the cardholder name.
        /// </summary>
        public string CardholderName { get; set; }
    }
}