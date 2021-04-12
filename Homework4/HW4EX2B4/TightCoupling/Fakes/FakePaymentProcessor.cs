namespace HW4EX2B4.TightCoupling.Model
{
    /// <summary>
    /// The fake payment processor.
    /// </summary>
    public class FakePaymentProcessor : IPaymentProcessor
    {
        /// <summary>
        /// The amount passed.
        /// </summary>
        public decimal amountPassed = 0;

        /// <summary>
        /// The was called.
        /// </summary>
        public bool wasCalled = false;

        /// <summary>
        /// The charge card.
        /// </summary>
        /// <param name="paymentDetails">
        /// The payment details.
        /// </param>
        /// <param name="amount">
        /// The amount.
        /// </param>
        public bool ChargeCard(PaymentDetails paymentDetails, decimal amount)
        {
            this.wasCalled = true;
            amountPassed = amount;

            return this.wasCalled;
        }
    }
}