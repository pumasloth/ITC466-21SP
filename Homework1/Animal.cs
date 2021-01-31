namespace Homework1
{
    using System;

    /// <summary>
    /// The animal class.
    /// </summary>
    public class Animal
    {
        /// <summary>
        /// Display a sound.
        /// </summary>
        public virtual void animalSound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }
}