namespace HW3EX1B4.Services
{
    using System;
    using HW3EX1B4.Exceptions;
    using HW3EX1B4.Model;
    using HW3EX1B4.Properties;

    public class PaymentGateway : IDisposable
    {
        public string CardNumber { get; set; }
        public string Credentials { get; set; }

        public string ExpiresMonth { get; set; }

        public string ExpiresYear { get; set; }

        public string NameOnCard { get; set; }

        public decimal AmountToCharge { get; set; }

        public void Charge()
        {
            throw new AvsMismatchException();
        }

        public void Dispose()
        {
        }

        /// <summary>
        /// Charge the credit card.
        /// </summary>
        /// <param name="paymentDetails">The <see cref="PaymentDetails"/>.</param>
        /// <param name="cart">The <see cref="Cart"/>.</param>
        /// <exception cref="ArgumentNullException">
        /// Thrown when paymentDetails or cart is null.
        /// </exception>
        /// <exception cref="OrderException">
        /// Thrown when the card is rejected based on the address provided.
        /// </exception>
        public static void ChargeCard(PaymentDetails paymentDetails, Cart cart)
        {
            if (paymentDetails == null)
            {
                throw new ArgumentNullException(nameof(paymentDetails));
            }

            if (cart == null)
            {
                throw new ArgumentNullException(nameof(cart));
            }

            using (var paymentGateway = new PaymentGateway())
            {
                try
                {
                    paymentGateway.Credentials = Settings.Default.PaymentGatewayCredentials;
                    paymentGateway.CardNumber = paymentDetails.CreditCardNumber;
                    paymentGateway.ExpiresMonth = paymentDetails.ExpiresMonth;
                    paymentGateway.ExpiresYear = paymentDetails.ExpiresYear;
                    paymentGateway.NameOnCard = paymentDetails.CardholderName;
                    paymentGateway.AmountToCharge = cart.TotalAmount;

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
            }
        }
    }
}