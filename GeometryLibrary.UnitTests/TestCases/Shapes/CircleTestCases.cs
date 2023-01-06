namespace GeometryLibrary.UnitTests.TestCases.Shapes
{
    public static class CircleTestCases
    {
        public static List<TestCaseData> CreateNewCircle_PositiveTestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(double.MaxValue),
                new(double.MaxValue/2),
                new(1),
            };

            return cases;
        }

        public static List<TestCaseData> CreateNewCircle_NegativeTestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(double.NegativeInfinity),
                new(double.PositiveInfinity),
                new(double.NaN),
                new(double.MinValue),
                new(0),
                new(-1),
            };

            return cases;
        }

        public static List<TestCaseData> CalculateArea_TestCases()
        {
            const double precision = 0.000000001;

            var cases = new List<TestCaseData>
            {
                new(1000, 3141592.653589793, precision),
                new(100, 31415.926535897, precision),
                new(0.01, 0.000314159, precision),
                new(1, 3.141592653, precision),
            };

            return cases;
        }
    }
}