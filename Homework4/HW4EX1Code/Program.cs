namespace HW4EX1Code
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            IBurgerOrderService burgerOrder = new BurgerOrderService();
            burgerOrder.OrderBurger(2);
        }
    }
}