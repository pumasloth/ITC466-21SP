namespace HW3EX1.Tests
{
    using System;
    using System.Collections.Generic;
    using Xunit;
    using HW3EX1B4.Exceptions;
    using HW3EX1B4.Model;
    using HW3EX1B4.Services;
    using HW3EX1B4.Utility;

    public class UnitTests
    {
        #region Models

        [Fact]
        private void CartTypeTest()
        {
            var cart = new Cart
            {
                CustomerEmail = "DoNotReply@example.com",
                TotalAmount = 1234.04m
            };

            Assert.IsType<Cart>(cart);
        }

        [Fact]
        private void OrderItemTypeTest()
        {
            var orderItem = new OrderItem
            {
                Sku = "123",
                Quantity = 10
            };

            Assert.IsType<OrderItem>(orderItem);
        }

        [Fact]
        private void CashOrderTypeTest()
        {
            var cashOrder = new CashOrder();
            Assert.IsType<CashOrder>(cashOrder);
        }

        [Fact]
        private void CreditCardOrderTypeTest()
        {
            var creditCardOrder = new CreditCardOrder();
            Assert.IsType<CreditCardOrder>(creditCardOrder);
        }

        [Fact]
        private void OnlineOrderTypeTest()
        {
            var onlineOrder = new OnlineOrder();
            Assert.IsType<OnlineOrder>(onlineOrder);
        }

        [Fact]
        private void CashOrderAssignableTest()
        {
            var cashOrder = new CashOrder();
            Assert.IsAssignableFrom<Order>(cashOrder);
        }

        [Fact]
        private void CreditCardOrderAssignableTest()
        {
            var creditCardOrder = new CreditCardOrder();
            Assert.IsAssignableFrom<Order>(creditCardOrder);
        }

        [Fact]
        private void OnlineOrderAssignableTest()
        {
            var onlineOrder = new OnlineOrder();
            Assert.IsAssignableFrom<Order>(onlineOrder);
        }

        [Fact]
        private void PaymentDetailsTypeTest()
        {
            var paymentDetails = new PaymentDetails()
            {
                CreditCardNumber = "1234-1234-1234-1234",
                ExpiresMonth = "01",
                ExpiresYear = "2021",
                CardholderName = "John Doe"
            };

            Assert.IsType<PaymentDetails>(paymentDetails);
        }

        #endregion

        #region Services

        [Fact]
        private void InventorySystemAssignableFromTest()
        {
            var inventorySystem = new InventorySystem();
            Assert.IsAssignableFrom<InventorySystem>(inventorySystem);
        }

        [Fact]
        private void NotificationServiceAssignableFromTest()
        {
            var notificationService =  new NotificationService();
            Assert.IsAssignableFrom<NotificationService>(notificationService);
        }

        [Fact]
        private void PaymentGatewayAssignableFromTest()
        {
            var paymentGateway = new PaymentGateway();
            Assert.IsAssignableFrom<PaymentGateway>(paymentGateway);
        }

        #endregion

        [Fact]
        private void PaymentDetailsEnumAssignableFromTest()
        {
            var paymentMethod = new PaymentDetails().PaymentMethod;
            Assert.IsAssignableFrom<Enum>(paymentMethod);
        }

        #region Utilities

        #endregion

        #region Exceptions

        [Fact]
        private void PaymentDetailsExceptionTest()
        {
            var paymentDetails = new PaymentDetails()
            {
                CreditCardNumber = "0000-0000-0000-0000",
                ExpiresMonth = "01",
                ExpiresYear = "2019",
                CardholderName = "John Doe"
            };

            var cart = new Cart
            {
                CustomerEmail = "DoNotReply@example.com",
                TotalAmount = 1234.04m
            };

            Assert.Throws<OrderException>(() => PaymentGateway.ChargeCard(paymentDetails, cart));
        }

        [Fact]
        private void InventorySystemExceptionTest()
        {
            Cart cart = null;
            Assert.Throws<ArgumentNullException>(() => InventorySystem.ReserveInventory(cart));

            cart = new Cart();
            var items = new List<OrderItem>();
            var item = new OrderItem
            {
                Quantity = 10,
                Sku = "123"
            };

            items.Add(item);
            cart.Items = items;
            Assert.Throws<OrderException>(() => InventorySystem.ReserveInventory(cart));
        }

        [Fact]
        private void EmailUtilityExceptionTest()
        {
            var toEmailAddress = string.Empty;
            object obj = null;
            Assert.Throws<ArgumentNullException>(() => EmailUtility.SendEmail(toEmailAddress, obj));
        }

        [Fact]
        private void PaymentGatewayExceptionTest()
        {
            PaymentDetails paymentDetails = null;
            Cart cart = null;
            Assert.Throws<ArgumentNullException>(() => PaymentGateway.ChargeCard(paymentDetails, cart));
        }

        #endregion
    }
}
