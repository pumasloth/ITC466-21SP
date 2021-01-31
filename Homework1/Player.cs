namespace Homework1
{
    using System;

    /// <summary>
    /// The player class.
    /// </summary>
    public class Player
    {
        /// <summary>
        /// Gets or sets the player's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the player's strength.
        /// </summary>
        public int Strength { get; set; }

        /// <summary>
        /// Gets or sets amount of damage a player is capable of doing.
        /// </summary>
        public int Damage { get; set; }

        /// <summary>
        /// Player attack.
        /// </summary>
        public virtual void Attack()
        {
            var random = new Random();

            // Add 1 to include the max.
            this.Damage = random.Next(1, this.Strength + 1);

            Console.WriteLine($"{this.Name} attacked for {this.Damage}.");
        }
    }
}
