using System;

namespace HW4EX2B4.TightCoupling.Services
{
    /// <summary>
    /// The payment gateway.
    /// </summary>
    public class PaymentGateway : IDisposable
    {
        /// <summary>
        /// Gets or sets the card number.
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Gets or sets the credentials.
        /// </summary>
        public string Credentials { get; set; }

        /// <summary>
        /// Gets or sets the expires month.
        /// </summary>
        public string ExpiresMonth { get; set; }

        /// <summary>
        /// Gets or sets the expires year.
        /// </summary>
        public string ExpiresYear { get; set; }

        /// <summary>
        /// Gets or sets the name on card.
        /// </summary>
        public string NameOnCard { get; set; }

        /// <summary>
        /// Gets or sets the amount to charge.
        /// </summary>
        public decimal AmountToCharge { get; set; }

        /// <summary>
        /// The charge.
        /// </summary>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool Charge()
        {
            var wasCalled = true;
            return wasCalled;
        }

        /// <summary>
        /// The dispose.
        /// </summary>
        public void Dispose()
        {
        }
    }

    /// <summary>
    /// The avs mismatch exception.
    /// </summary>
    public class AvsMismatchException : Exception
    {
    }
}