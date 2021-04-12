using System;
using System.Net.Mail;
using HW4EX2B4.Utility;

namespace HW4EX2B4.TightCoupling.Model
{
    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The notify customer service.
    /// </summary>
    public class NotifyCustomerService : INotifyCustomer
    {
        /// <summary>
        /// The notify customer.
        /// </summary>
        /// <param name="cart">
        /// The cart.
        /// </param>
        /// <param name="mailMessage">
        /// The mail message.
        /// </param>
        /// <param name="smtpClient">
        /// The smtp client.
        /// </param>
        /// <returns>
        /// True when called.
        /// </returns>
        public bool NotifyCustomer(Cart cart)
        {
            var wasCalled = true;

            string customerEmail = cart.CustomerEmail;
            if (!string.IsNullOrEmpty(customerEmail))
            {
                var serviceProvider = Startup.ConfigureService();

                // How to new up the mailmessage for the to/from address?
                var mailMessage = serviceProvider.GetRequiredService<MailMessage>();
                mailMessage.Subject = "Your order placed on " + DateTime.Now;
                mailMessage.Body = "Your order details: \n " + cart;
                var smtpClient = serviceProvider.GetRequiredService<SmtpClient>();
                
                // Move to resource file.
                smtpClient.Host = "127.0.0.1";
                try
                {
                    smtpClient.Send(mailMessage);
                    smtpClient.Dispose();
                }
                catch (Exception ex)
                {
                    Logger.Error("Problem sending notification email", ex);
                    throw;
                }
            }

            return wasCalled;
        }
    }
}