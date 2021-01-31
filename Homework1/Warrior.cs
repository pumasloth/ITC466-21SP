namespace Homework1
{
    using System;

    /// <summary>
    /// The warrior class.
    /// </summary>
    public class Warrior : Player
    {
        /// <summary>
        /// Gets or sets the warrior's bonus.
        /// </summary>
        public int Bonus { get; set; }

        /// <summary>
        /// Warrior attack.
        /// </summary>
        public override void Attack()
        {
            var random = new Random();

            // Add 1 to include the max.
            this.Damage = random.Next(1, this.Strength + 1);

            Console.WriteLine($"{this.Name} charges for {this.Damage} damage (includes +{this.Bonus} bonus).");
        }
    }
}