namespace HW3EX3
{
    /// <summary>
    /// The rectangle class.
    /// </summary>
    public class Rectangle : Shape
    {
        /// <summary>
        /// Gets or sets the height of the rectangle.
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// Gets or sets the width of the rectangle.
        /// </summary>
        public int Width { get; set; }

        /// <summary>
        /// Calculate the area of the rectangle.
        /// </summary>
        /// <returns>The area of the rectangle.</returns>
        public override int Area() => this.Height * this.Width;
    }
}