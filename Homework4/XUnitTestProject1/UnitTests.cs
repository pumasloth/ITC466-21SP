namespace XUnitTestProject1
{
    using System;
    using Xunit;
    using HW4EX2B4.TightCoupling.Model;
    using HW4EX2B4.TightCoupling.Services;
    using HW4EX2B4.Utility;
    using Microsoft.Extensions.DependencyInjection;

    public class UnitTests
    {
        /// <summary>
        /// The _service provider.
        /// </summary>
        private IServiceProvider _serviceProvider;

        /// <summary>
        /// Prevents a default instance of the <see cref="UnitTests"/> class from being created.
        /// </summary>
        public UnitTests()
        {
            this._serviceProvider = Startup.ConfigureService();
        }

        [Fact]
        private void FakeNotifyCustomer()
        {
            var fakeNotifyCustomer = _serviceProvider.GetRequiredService<FakeNotifyCustomer>();

            Assert.True(fakeNotifyCustomer.NotifyCustomer(null));
        }

        [Fact]
        private void FakePaymentProcessor()
        {
            var fakePaymentProcessor = _serviceProvider.GetRequiredService<FakePaymentProcessor>();

            Assert.True(fakePaymentProcessor.ChargeCard(null, 4000));
        }

        [Fact]
        private void FakeReserveInventory()
        {
            var fakeReserveInventory = _serviceProvider.GetRequiredService<FakeReserveInventory>();

            Assert.True(fakeReserveInventory.ReserveInventory(null));
        }

        [Fact]
        private void ReserveInventoryItem()
        {
            var inventorySystem = _serviceProvider.GetRequiredService<InventorySystem>();

            Assert.True(inventorySystem.Reserve("123", 5));
        }

        [Fact]
        private void ChargeCreditCard()
        {
            var paymentGateway = _serviceProvider.GetRequiredService<PaymentGateway>();

            Assert.True(paymentGateway.Charge());
        }
    }
}
