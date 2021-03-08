namespace HW3EX1B4.Model
{
    /// <summary>
    /// The enum for valid payment methods.
    /// </summary>
    public enum PaymentMethod
    {
        Cash,
        CreditCard
    }

    /// <summary>
    /// The payment details class.
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
        /// Gets or sets expiration month.
        /// </summary>
        public string ExpiresMonth { get; set; }

        /// <summary>
        /// Gets or sets the expiration year.
        /// </summary>
        public string ExpiresYear { get; set; }

        /// <summary>
        /// Gets or sets the card holder name.
        /// </summary>
        public string CardholderName { get; set; }
    }
}