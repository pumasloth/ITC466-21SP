namespace HW4EX1CodeTests
{
    using HW4EX1Code;

    using Xunit;

    /// <summary>
    /// The unit test class.
    /// </summary>
    public class Hw4Ex1CodeTests
    {
        /// <summary>
        /// The order a burger.
        /// </summary>
        [Fact]
        public void OrderABurger()
        {
            var burgerService = new BurgerOrderService();
            Assert.True(burgerService.OrderBurger(5));
        }

        /// <summary>
        /// The order a fry.
        /// </summary>
        [Fact]
        public void OrderAFry()
        {
            var friesService = new FriesOrderService();
            Assert.True(friesService.OrderFries(5));
        }

        /// <summary>
        /// The order a combo.
        /// </summary>
        [Fact]
        public void OrderACombo()
        {
            var comboService = new ComboOrderService();
            Assert.True(comboService.OrderCombo(5));
        }

        /// <summary>
        /// The submit order.
        /// </summary>
        [Fact]
        public void SubmitOrder()
        {
            var orderService = new OrderService();
            Assert.True(orderService.SubmitOrder("Dr. Pepper"));
        }
    }
}
