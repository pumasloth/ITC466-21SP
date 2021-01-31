namespace Homework1
{
    using System;

    /// <summary>
    /// The wizard class.
    /// </summary>
    public class Wizard : Player
    {
        /// <summary>
        /// Gets or sets the wizard's energy.
        /// </summary>
        public int Energy { get; set; }

        /// <summary>
        /// Wizard attack.
        /// </summary>
        public override void Attack()
        {
            var random = new Random();

            // Add 1 to include the max.
            this.Damage = random.Next(1, this.Strength + 1);

            // Deplete a random amount of Energy between 1 and 10.
            var energyDepleted = random.Next(1, 11);
            this.Energy -= energyDepleted;

            Console.WriteLine($"{this.Name} attacked for {this.Damage} damage.");
            Console.WriteLine($"\t(Wizard {this.Name} depleted {energyDepleted} energy).");
        }
    }
}