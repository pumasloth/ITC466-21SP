namespace Homework1
{
    using System;

    /// <summary>
    /// The dog class.
    /// </summary>
    public class Dog : Animal
    {
        /// <summary>
        /// Display the sound a dog makes.
        /// </summary>
        public override void animalSound()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }
}
