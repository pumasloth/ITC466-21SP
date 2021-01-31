namespace Homework1
{
    using System;

    /// <summary>
    /// The TShirt class.
    /// </summary>
    public class TShirt : IPurchasable, IShippable, ITaxable
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets or sets the shipping rate.
        /// </summary>
        public double ShippingRate { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        public double TaxRate { get; set; }

        /// <summary>
        /// Display the size and price of a t-shirt.
        /// </summary>
        public void Purchase()
        {
            Console.WriteLine($"Purchasing TShirt {this.Size} for {this.Price.ToString("C0")}.");
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
