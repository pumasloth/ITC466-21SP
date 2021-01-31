namespace Homework1
{
    using System;

    /// <summary>
    /// The pig class.
    /// </summary>
    public class Pig : Animal
    {
        /// <summary>
        /// Display the sound a pig makes.
        /// </summary>
        public override void animalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }
}