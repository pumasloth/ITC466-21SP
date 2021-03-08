namespace HW3EX3.Utilities
{
    /// <summary>
    /// The area calculator class.
    /// </summary>
    public class AreaCalculator
    {
        /// <summary>
        /// Calculate the area of a shape.
        /// </summary>
        /// <param name="shape">The <see cref="Shape"/> to calculate the area.</param>
        /// <returns>The area of the shape.</returns>
        public static int CalculateArea(Shape shape)
        {
            return shape.Area();
        }
    }
}