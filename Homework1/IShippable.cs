namespace Homework1
{
    /// <summary>
    /// The IShippable interface.
    /// </summary>
    public interface IShippable
    {
        /// <summary>
        /// Gets or sets the shipping rate.
        /// </summary>
        double ShippingRate { get; set; }

        /// <summary>
        /// The shipping method.
        /// </summary>
        void Ship();
    }
}
