using GeometryLibrary.Helpers;

namespace GeometryLibrary.Shapes
{
    /// <summary>
    /// Data model containing information about a geometric figure:  triangle
    /// </summary>
    public class Triangle : GeometricShapeBase
    {
        /// <summary>
        /// First side of triangle
        /// </summary>
        public double FirstSide { get; set; }

        /// <summary>
        /// Second side of triangle
        /// </summary>
        public double SecondSide { get; set; }

        /// <summary>
        /// Third side of triangle
        /// </summary>
        public double ThirdSide { get; set; }

        /// <summary>
        /// True if the triangle exists
        /// </summary>
        public bool IsExists =>
            FirstSide + ThirdSide > SecondSide
            && FirstSide + SecondSide > ThirdSide
            && SecondSide + ThirdSide > FirstSide;

        /// <summary>
        /// Value of the comparison accuracy. Used to check whether a triangle is rectangular
        /// </summary>
        public double Epsilon { get; set; } = double.Epsilon;

        /// <summary>
        /// ctr.
        /// </summary>
        /// <param name="firstSide">First side of triangle</param>
        /// <param name="secondSide">Second side of triangle</param>
        /// <param name="thirdSide">Third side of triangle</param>
        /// <exception cref="ArgumentOutOfRangeException">
        /// If <paramref name="firstSide"/>, <paramref name="secondSide"/> or <paramref name="thirdSide"/>
        /// is not normal, either less than or equal to 0
        /// </exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            firstSide.ThrowIfOutOfNormalPositiveRange(nameof(firstSide));
            secondSide.ThrowIfOutOfNormalPositiveRange(nameof(secondSide));
            thirdSide.ThrowIfOutOfNormalPositiveRange(nameof(thirdSide));

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public override double CalculateArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Math.Sqrt(semiPerimeter
                             * (semiPerimeter - FirstSide)
                             * (semiPerimeter - SecondSide)
                             * (semiPerimeter - ThirdSide));
        }

        /// <summary>
        /// True if it is a right triangle
        /// </summary>
        public bool IsSquareness()
        {
            if (!IsExists)
            {
                return false;
            }

            var firstSide = FirstSide;
            var secondSide = SecondSide;
            var thirdSide = ThirdSide;

            if (thirdSide < secondSide)
            {
                (thirdSide, secondSide) = (secondSide, thirdSide);
            }
            if (thirdSide < firstSide)
            {
                (thirdSide, firstSide) = (firstSide, thirdSide);
            }

            return Math.Abs(Math.Pow(thirdSide, 2) - (Math.Pow(firstSide, 2) + Math.Pow(secondSide, 2))) < Epsilon;
        }
    }
}