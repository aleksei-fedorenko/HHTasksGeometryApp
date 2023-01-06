namespace GeometryLibrary.UnitTests.TestCases.Shapes
{
    public static class TriangleTestCases
    {
        public static List<TestCaseData> CreateNewTriangle_PositiveTestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(double.MaxValue, double.MaxValue, double.MaxValue),
                new(double.MaxValue/2, double.MaxValue/2, double.MaxValue/2),
                new(1, 1, 1),
            };

            return cases;
        }

        public static List<TestCaseData> CreateNewTriangle_NegativeTestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(double.NegativeInfinity, 1, 1),
                new(1, double.NegativeInfinity, 1),
                new(1, 1, double.NegativeInfinity),

                new(double.PositiveInfinity, 1, 1),
                new(1, double.PositiveInfinity, 1),
                new(1, 1, double.PositiveInfinity),

                new(double.NaN, 1, 1),
                new(1, double.NaN, 1),
                new(1, 1, double.NaN),

                new(double.MinValue, 1, 1),
                new(1, double.MinValue, 1),
                new(1, 1, double.MinValue),

                new(0, 1, 1),
                new(1, 0, 1),
                new(1, 1, 0),

                new(-1, 1, 1),
                new(1, -1, 1),
                new(1, 1, -1),
            };

            return cases;
        }

        public static List<TestCaseData> IsExists_Test()
        {
            var cases = new List<TestCaseData>
            {
                new(9, 9, 18, false),
                new(6.4, 5.6, 12, false),
                new(4, 6, 7, true),
                new(9.6, 8.9, 12.6, true),
            };

            return cases;
        }

        public static List<TestCaseData> CalculateArea_TestCases()
        {
            const double precision = 0.000000001;

            var cases = new List<TestCaseData>
            {
                new(9, 9, 18, 0, precision),
                new(6.4, 5.6, 12, 0,precision),
                new(4, 6, 7, 11.976539567, precision),
                new(9.6, 8.9, 12.6, 42.603522668, precision),
            };

            return cases;
        }

        public static List<TestCaseData> IsSquareness_TestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(3, 4, 5, true),
                new(5, 12, 13, true),
                new(5, 5, 3, false),
                new(2, 2, 2, false),
                new(3, 6, 5, false),
                new(3.5, 6.7, 5.1, false),
            };

            return cases;
        }
    }
}