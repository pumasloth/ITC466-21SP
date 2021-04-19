namespace HW5AsyncCoffee.Tests
{
    using System;
    using System.Threading.Tasks;

    using HW5AsyncCoffee;

    using Xunit;

    /// <summary>
    /// The unit test 1.
    /// </summary>
    public class UnitTests
    {
        /// <summary>
        /// The apply butter true test.
        /// </summary>
        [Fact]
        public void ApplyButterReturnsTrueTest()
        {
            var toast = new Toast();
            var applyButter = Program.ApplyButter(toast);

            Assert.True(applyButter);
        }

        /// <summary>
        /// The apply jam true test.
        /// </summary>
        [Fact]
        public void ApplyJamReturnsTrueTest()
        {
            var toast = new Toast();
            var applyJam = Program.ApplyJam(toast);

            Assert.True(applyJam);
        }

        /// <summary>
        /// The fry eggs async.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task FryBaconIsTypeBaconAsyncTest()
        {
            var task = await Program.FryBaconAsync(1);

            Assert.IsType<Bacon>(task);
        }

        /// <summary>
        /// The pour coffee test.
        /// </summary>
        [Fact]
        public void PourCoffeeIsTypeCoffeeTest()
        {
            var coffee = Program.PourCoffee();

            Assert.IsType<Coffee>(coffee);
        }

        /// <summary>
        /// The pour OJ test.
        /// </summary>
        [Fact]
        public void PourOjIsTypeJuiceTest()
        {
            var oj = Program.PourOJ();

            Assert.IsType<Juice>(oj);
        }

        /// <summary>
        /// The make toast with butter and jam async test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task MakeToastWithButterAndJamIsTypeToastAsyncTest()
        {
            var task = await Program.MakeToastWithButterAndJamAsync(1);

            Assert.IsType<Toast>(task);
        }

        /// <summary>
        /// The toast bread async test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task ToastBreadIsTypeToastAsyncTest()
        {
            var task = await Program.ToastBreadAsync(1);

            Assert.IsType<Toast>(task);
        }

        #region ArgumentOutOfRangeException

        /// <summary>
        /// The toast bread async zero exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task ToastBreadAsyncZeroExceptionTest()
        {
            async Task task() => await Program.ToastBreadAsync(0);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The toast bread async negative exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task ToastBreadAsyncNegativeExceptionTest()
        {
            async Task task() => await Program.ToastBreadAsync(-5);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The make toast with butter and jam async zero exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task MakeToastWithButterAndJamAsyncZeroExceptionTest()
        {
            async Task task() => await Program.MakeToastWithButterAndJamAsync(0);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The make toast with butter and jam async negative exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task MakeToastWithButterAndJamAsyncNegativeExceptionTest()
        {
            async Task task() => await Program.MakeToastWithButterAndJamAsync(-5);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The fry bacon async zero exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task FryBaconAsyncZeroExceptionTest()
        {
            async Task task() => await Program.FryBaconAsync(0);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The fry bacon async negative exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task FryBaconAsyncNegativeExceptionTest()
        {
            async Task task() => await Program.FryBaconAsync(-5);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The fry eggs async zero exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task FryEggsAsyncZeroExceptionTest()
        {
            async Task task() => await Program.FryEggsAsync(0);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        /// <summary>
        /// The fry eggs async negative exception test.
        /// </summary>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        [Fact]
        public async Task FryEggsAsyncNegativeExceptionTest()
        {
            async Task task() => await Program.FryEggsAsync(-5);
            await Assert.ThrowsAsync<ArgumentOutOfRangeException>(task);
        }

        #endregion
    }
}
