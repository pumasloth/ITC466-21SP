namespace Homework1
{
    /// <summary>
    /// The IPurchasable interface.
    /// </summary>
    public interface IPurchasable
    {
        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        double Price { get; set; }

        /// <summary>
        /// The purchase method.
        /// </summary>
        void Purchase();
    }
}
