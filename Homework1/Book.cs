namespace Homework1
{
    using System;

    /// <summary>
    /// The Book class.
    /// </summary>
    public class Book : IPurchasable, ITaxable, IShippable
    {
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the shipping rate.
        /// </summary>
        public double ShippingRate { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        public double TaxRate { get; set; }

        /// <summary>
        /// Display the title and price of a book.
        /// </summary>
        public void Purchase()
        {
            Console.WriteLine($"Purchasing {this.Title} for {this.Price.ToString("C0")}.");
        }

        /// <summary>
        /// Display the rate for shipping.
        /// </summary>
        public void Ship()
        {
            Console.WriteLine($"    ShippingRate: {this.ShippingRate:C0}");
        }

        /// <summary>
        /// Calculate and display the tax rate.
        /// </summary>
        /// <returns>The tax rate.</returns>
        public double Tax()
        {
            var tax = this.Price * this.TaxRate;
            Console.WriteLine($"    TaxRate: {this.TaxRate} = {tax}");
            return tax;
        }
    }
}
