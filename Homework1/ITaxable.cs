namespace Homework1
{
    /// <summary>
    /// The ITaxable interface.
    /// </summary>
    public interface ITaxable
    {
        /// <summary>
        /// Gets or sets the tax rate.
        /// </summary>
        double TaxRate { get; set; }

        /// <summary>
        /// Calculate and display the tax rate.
        /// </summary>
        /// <returns>The tax rate.</returns>
        double Tax();
    }
}
