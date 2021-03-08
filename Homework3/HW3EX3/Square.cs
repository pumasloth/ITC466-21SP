namespace HW3EX3
{
    /// <summary>
    /// The square class.
    /// </summary>
    public class Square : Shape
    {
        /// <summary>
        /// Gets or sets the side length of the square.
        /// </summary>
        public int SideLength { get; set; }

        /// <summary>
        /// Calculate the area of the square.
        /// </summary>
        /// <returns>The area of the square.</returns>
        public override int Area() => this.SideLength * this.SideLength;
    }
}