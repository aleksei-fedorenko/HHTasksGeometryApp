namespace GeometryLibrary
{
    /// <summary>
    /// Basic data model describing a geometric shape
    /// </summary>
    public abstract class GeometricShapeBase
    {
        /// <summary>
        /// Function for calculating the area of a figure
        /// </summary>
        public abstract double CalculateArea();
    }
}