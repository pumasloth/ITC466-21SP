namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The PaymentProcessor interface.
    /// </summary>
    public interface IPaymentProcessor
    {
        /// <summary>
        /// The charge card.
        /// </summary>
        /// <param name="paymentDetails">
        /// The payment details.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        bool ChargeCard(PaymentDetails paymentDetails, decimal amount);
    }
}