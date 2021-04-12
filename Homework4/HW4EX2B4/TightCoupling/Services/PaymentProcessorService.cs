using System;
using HW4EX2B4.TightCoupling.Services;

namespace HW4EX2B4.TightCoupling.Model
{
    using HW4EX2B4.Utility;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The payment processor service.
    /// </summary>
    public class PaymentProcessorService : IPaymentProcessor
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
        /// <exception cref="OrderException">
        /// Thrown when the credit order is rejected.
        /// </exception>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool ChargeCard(PaymentDetails paymentDetails, decimal amount)
        {
            var wasCalled = true;

            var serviceProvider = Startup.ConfigureService();
            var paymentGateway = serviceProvider.GetRequiredService<PaymentGateway>();
            try
            {
                paymentGateway.Credentials = "account credentials";
                paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                paymentGateway.NameOnCard = paymentDetails.CardholderName;
                paymentGateway.AmountToCharge = amount;

                paymentGateway.Charge();
            }
            catch (AvsMismatchException ex)
            {
                throw new OrderException("The card gateway rejected the card based on the address provided.", ex);
            }
            catch (Exception ex)
            {
                throw new OrderException("There was a problem with your card.", ex);
            }

            return wasCalled;
        }
    }
}