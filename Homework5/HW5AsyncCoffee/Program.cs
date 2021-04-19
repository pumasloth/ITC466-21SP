namespace HW5AsyncCoffee
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

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
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        public static async Task Main(string[] args)
        {
            Coffee cup = PourCoffee();
            Console.WriteLine("coffee is ready");

            var eggsTask = FryEggsAsync(2);
            var baconTask = FryBaconAsync(3);
            var toastTask = MakeToastWithButterAndJamAsync(2);

            var breakfastTasks = new List<Task> { eggsTask, baconTask, toastTask };
            while (breakfastTasks.Count > 0)
            {
                Task finishedTask = await Task.WhenAny(breakfastTasks);
                if (finishedTask == eggsTask)
                {
                    Console.WriteLine("eggs are ready");
                }
                else if (finishedTask == baconTask)
                {
                    Console.WriteLine("bacon is ready");
                }
                else if (finishedTask == toastTask)
                {
                    Console.WriteLine("toast is ready");
                }

                breakfastTasks.Remove(finishedTask);
            }

            Juice oj = PourOJ();
            Console.WriteLine("oj is ready");
            Console.WriteLine("Breakfast is ready!");
        }

        /// <summary>
        /// The pour OJ.
        /// </summary>
        /// <returns>
        /// The <see cref="Juice"/>.
        /// </returns>
        public static Juice PourOJ()
        {
            Console.WriteLine("Pouring orange juice");
            return new Juice();
        }

        /// <summary>
        /// The apply jam.
        /// </summary>
        /// <param name="toast">
        /// The toast.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/> of true when called.
        /// </returns>
        public static bool ApplyJam(Toast toast)
        {
            Console.WriteLine("Putting jam on the toast");
            return true;
        }

        /// <summary>
        /// The apply butter.
        /// </summary>
        /// <param name="toast">
        /// The toast.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/> of true when called.
        /// </returns>
        public static bool ApplyButter(Toast toast)
        {
            Console.WriteLine("Putting butter on the toast");
            return true;
        } 

        /// <summary>
        /// The make toast with butter and jam async.
        /// </summary>
        /// <param name="number">
        /// The number.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when number is less than or equal to zero.
        /// </exception>
        public static async Task<Toast> MakeToastWithButterAndJamAsync(int number)
        {
            if (number <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(number), $"{nameof(number)} must be at least one or greater.");
            }

            var toast = await ToastBreadAsync(number);

            // Return value not used for these two methods.
            var applyButter = ApplyButter(toast);
            var applyJam = ApplyJam(toast);

            return toast;
        }

        /// <summary>
        /// The toast bread async.
        /// </summary>
        /// <param name="slices">
        /// The number of slices.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when slices is less than or equal to zero.
        /// </exception>
        public static async Task<Toast> ToastBreadAsync(int slices)
        {
            if (slices <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(slices), $"{nameof(slices)} must be at least one or greater.");
            }

            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("Putting a slice of bread in the toaster");
            }

            Console.WriteLine("Start toasting...");
            await Task.Delay(3000);
            Console.WriteLine("Remove toast from toaster");

            return new Toast();
        }

        /// <summary>
        /// The fry bacon async.
        /// </summary>
        /// <param name="slices">
        /// The number of slices.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when slices is less than or equal to zero.
        /// </exception>
        public static async Task<Bacon> FryBaconAsync(int slices)
        {
            if (slices <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(slices), $"{nameof(slices)} must be at least one or greater.");
            }

            Console.WriteLine($"putting {slices} slices of bacon in the pan");
            Console.WriteLine("cooking first side of bacon...");
            await Task.Delay(3000);
            for (int slice = 0; slice < slices; slice++)
            {
                Console.WriteLine("flipping a slice of bacon");
            }

            Console.WriteLine("cooking the second side of bacon...");
            await Task.Delay(3000);
            Console.WriteLine("Put bacon on plate");

            return new Bacon();
        }

        /// <summary>
        /// The fry eggs async.
        /// </summary>
        /// <param name="howMany">
        /// How many eggs.
        /// </param>
        /// <returns>
        /// The <see cref="Task"/>.
        /// </returns>
        /// <exception cref="ArgumentOutOfRangeException">
        /// Thrown when howMany is less than or equal to zero.
        /// </exception>
        public static async Task<Egg> FryEggsAsync(int howMany)
        {
            if (howMany <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(howMany), $"{nameof(howMany)} must be at least one or greater.");
            }

            Console.WriteLine("Warming the egg pan...");
            await Task.Delay(3000);
            Console.WriteLine($"cracking {howMany} eggs");
            Console.WriteLine("cooking the eggs ...");
            await Task.Delay(3000);
            Console.WriteLine("Put eggs on plate");
            
            return new Egg();
        }

        /// <summary>
        /// The pour coffee.
        /// </summary>
        /// <returns>
        /// The <see cref="Coffee"/>.
        /// </returns>
        public static Coffee PourCoffee()
        {
            Console.WriteLine("Pouring coffee");
            return new Coffee();
        }
    }
}
