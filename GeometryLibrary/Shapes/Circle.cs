using GeometryLibrary.Helpers;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Data model containing information about a geometric figure:  circle
    /// </summary>
    public class Circle : GeometricShapeBase
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// ctr.
        /// </summary>
        /// <param name="radius">Circle radius</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// If <paramref name="radius"/>
        /// is not normal, either less than or equal to 0
        /// </exception>
        public Circle(double radius)
        {
            radius.ThrowIfOutOfNormalPositiveRange(nameof(radius));

            Radius = radius;
        }

        public override double CalculateArea()
            => Math.PI * Math.Pow(Radius, 2);
    }
}