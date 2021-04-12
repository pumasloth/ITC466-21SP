namespace HW4EX2B4.Utility
{
    using System;
    using System.Net.Mail;

    using HW4EX2B4.TightCoupling.Model;
    using HW4EX2B4.TightCoupling.Services;

    using Microsoft.Extensions.DependencyInjection;

    /// <summary>
    /// The startup.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// The configure service.
        /// </summary>
        /// <returns>
        /// The <see cref="IServiceProvider"/>.
        /// </returns>
        public static IServiceProvider ConfigureService()
        {
            var serviceCollection = new ServiceCollection()
                .AddSingleton<MailMessage>()
                .AddSingleton<SmtpClient>()
                .AddSingleton<PaymentGateway>()
                .AddSingleton<InventorySystem>()
                .AddSingleton<FakeReserveInventory>()
                .AddSingleton<FakePaymentProcessor>()
                .AddSingleton<FakeNotifyCustomer>()
                .AddSingleton<PaymentDetails>()
                .AddSingleton<Cart>()
                .AddSingleton<CashOrder>()
                .AddSingleton<CreditCardOrder>()
                .AddSingleton<OnlineOrder>()
                .BuildServiceProvider();

            return serviceCollection;
        }
    }
}
