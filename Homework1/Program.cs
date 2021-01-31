namespace Homework1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The homework template class.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Display the menu and run the selection.
        /// </summary>
        /// <param name="args">Arguments.</param>
        public static void Main(string[] args)
        {
            string result;

            do
            {
                result = DisplayMenu();
                Run(result);
            }
            while (result.ToUpper() != "E");

            Console.WriteLine(" Good Bye...");
        }

        /// <summary>
        /// Display the menu for the user to select.
        /// </summary>
        /// <returns>The user selection.</returns>
        public static string DisplayMenu()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Homework 1");
            Console.WriteLine();
            Console.WriteLine("Hit [1] to run Exercise 1.");
            Console.WriteLine("Hit [2] to run Exercise 2.");
            Console.WriteLine("Hit [3] to run Exercise 3.");
            Console.WriteLine("Hit [4] to run Exercise 4.");
            Console.WriteLine("Hit [5] to run Exercise 5.");

            Console.WriteLine();
            Console.WriteLine("Hit [E]: Exit;");
            Console.WriteLine();
            Console.WriteLine();

            var result = Console.ReadLine();
            return result;
        }

        /// <summary>
        /// Run the selection.
        /// </summary>
        /// <param name="exeArg">The menu item to execute.</param>
        /// <returns>Boolean of success.</returns>
        private static bool Run(string exeArg)

        {
            switch (exeArg.ToLower())
            {
                case "1":
                    DoExe1();
                    return true;

                case "2":
                    DoExe2();
                    return true;

                case "3":
                    DoExe3();
                    return true;

                case "4":
                    DoExe4();
                    return true;

                case "5":
                    DoExe5();
                    return true;

                default:
                    Console.WriteLine("Exiting the Program!");
                    return true;
            }
        }

        /// <summary>
        /// Display different animals and their sound.
        /// </summary>
        private static void DoExe1()
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myDog = new Dog();  // Create a Dog object

            myAnimal.animalSound();
            myPig.animalSound();
            myDog.animalSound();

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        /// <summary>
        /// Play a game against the computer using characters.
        /// </summary>
        private static void DoExe2()
        {
            var player = new Player() { Name = "Bob", Strength = 20 };
            var warrior = new Warrior() { Name = "Baltek", Strength = 100, Bonus = 10 };
            var wizard = new Wizard() { Name = "Pentagorn", Strength = 50, Energy = 50 };

            var players = new List<Player>();
            players.Add(player);
            players.Add(warrior);
            players.Add(wizard);

            // Start the battle and may the odds be in your favor.
            DoBattle(players);

            // Pause until the user hits enter.
            Console.ReadLine();
        }

        /// <summary>
        /// Calculate and display the total cost of purchased items.
        /// </summary>
        private static void DoExe3()
        {
            var appointment = new Appointment()
            {
                Name = "Bob",
                StartDateTime = DateTime.Now.AddHours(1),
                EndDateTime = DateTime.Now.AddHours(2),
                Price = 100D
            };

            var book = new Book()
            {
                Title = "How to Implement Interfaces",
                Price = 50D,
                ShippingRate = 2.00,
                TaxRate = 0.0825D
            };

            var snack = new Snack()
            {
                Price = 2D
            };

            var tshirt = new TShirt()
            {
                Size = "2X",
                Price = 25D,
                ShippingRate = 5.00,
                TaxRate = 0.0625D
            };

            // Create a list of purchasable items.
            var items = new List<IPurchasable>();
            items.Add(appointment);
            items.Add(book);
            items.Add(snack);
            items.Add(tshirt);

            var taxableItems = new List<ITaxable>();
            foreach (var item in items)
            {
                if (item is ITaxable)
                {
                    taxableItems.Add(item as ITaxable);
                }
            }

            var taxAmount = CalculateTax(taxableItems);
            Console.WriteLine($"Total tax amount: {taxAmount:C}");

            // New line.
            Console.WriteLine();

            // Create a list of shippable items.
            var shippableItems = new List<IShippable>();
            shippableItems.Add(book);
            shippableItems.Add(tshirt);

            var shippingTotal = CalculateShipping(shippableItems);
            Console.WriteLine($"Total shipping amount: {shippingTotal:C}");

            // New line.
            Console.WriteLine();

            CompleteTransaction(items);
            CalculateGrandTotal(items, taxAmount, shippingTotal);

            // Pause until the user hits enter.
            Console.ReadKey();
        }

        private static void DoExe4()
        {
            // Add code for Exercise 4 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }

        private static void DoExe5()
        {
            // Add code for Exercise 5 here
            // Remove "throw new NotImplementedException()" line of code 
            //  once you add your code.
            throw new NotImplementedException();
        }

        /// <summary>
        /// Exercise 2.
        /// </summary>
        /// <param name="players">The list of <see cref="Player"/>.</param>
        private static void DoBattle(List<Player> players)
        {
            foreach (var player in players)
            {
                player.Attack();
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Calculate the cost of tax.
        /// </summary>
        /// <param name="items">The list of <see cref="ITaxable"/>.</param>
        /// <returns>The total cost of tax.</returns>
        private static double CalculateTax(List<ITaxable> items)
        {
            double tax = 0D;

            foreach (var item in items)
            {
                tax += item.Tax();
            }

            return tax;
        }

        /// <summary>
        /// Calculate the cost of shipping.
        /// </summary>
        /// <param name="items">The list of <see cref="IShippable"/>.</param>
        /// <returns>The total cost of shipping.</returns>
        private static double CalculateShipping(List<IShippable> items)
        {
            double shipping = 0D;

            foreach (var item in items)
            {
                shipping += item.ShippingRate;
                item.Ship();
            }

            return shipping;
        }

        /// <summary>
        /// Complete the pending transaction and purchase all items.
        /// </summary>
        /// <param name="items">The list of <see cref="IPurchasable"/>.</param>
        private static void CompleteTransaction(List<IPurchasable> items)
        {
            items.ForEach(p => p.Purchase());
        }

        /// <summary>
        /// Calculate grand total amount including all purchased items
        /// and tax and shipping where applicable and display it in the console window.
        /// </summary>
        /// <param name="items">The list of <see cref="IPurchasable"/>.</param>
        /// <param name="totalTax">Total tax amount.</param>
        /// <param name="totalShipping">Total shipping amount.</param>
        private static void CalculateGrandTotal(List<IPurchasable> items, double totalTax, double totalShipping)
        {
            double grandTotal = 0D;

            var equalSigns = new string('=', 12);
            Console.WriteLine(equalSigns);

            var priceSum = items.Sum(item => item.Price);
            grandTotal = priceSum + totalTax + totalShipping;

            Console.WriteLine($"Grand Total: {grandTotal:C}");
        }
    }
}