using HW4EX2B4.TightCoupling.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HW4EX2B4.TightCoupling
{
    using HW4EX2B4.Utility;

    using Microsoft.Extensions.DependencyInjection;

    [TestClass]
    public class OrderCheckoutShould
    {
       [TestMethod]
        public void NotFailWithNoItemsNoNotificationCreditCard()
        {
            var serviceProvider = Startup.ConfigureService();
            var paymentService = serviceProvider.GetRequiredService<FakePaymentProcessor>();
            var paymentDetails = serviceProvider.GetRequiredService<PaymentDetails>();
            var order = serviceProvider.GetRequiredService<CreditCardOrder>();

            paymentDetails.PaymentMethod = PaymentMethod.CreditCard;

            order.Checkout();

            Assert.IsTrue(paymentService.wasCalled);

            // if I got here, I guess it worked...
        }

        [TestMethod]
        public void NotFailWithNoItemsNotificationNoCreditCard()
        {
            var serviceProvider = Startup.ConfigureService();
            var notificationService = serviceProvider.GetRequiredService<FakeNotifyCustomer>();
            var paymentDetails = serviceProvider.GetRequiredService<PaymentDetails>();
            var order = serviceProvider.GetRequiredService<CashOrder>();

            paymentDetails.PaymentMethod = PaymentMethod.Cash;

            order.Checkout();

            Assert.IsTrue(notificationService.wasCalled);
        }
    }
}
