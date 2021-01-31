namespace Homework1
{
    using System;

    /// <summary>
    /// The appointment class.
    /// </summary>
    public class Appointment : IPurchasable
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the start date time.
        /// </summary>
        public DateTime StartDateTime { get; set; }

        /// <summary>
        /// Gets or sets the end date time.
        /// </summary>
        public DateTime EndDateTime { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Display the details for the appointment.
        /// </summary>
        public void Purchase()
        {
            Console.WriteLine($"Payment for Appointment for {this.Name} from {this.StartDateTime} to {this.EndDateTime} for {this.Price.ToString("C0")}.");
        }
    }
}
