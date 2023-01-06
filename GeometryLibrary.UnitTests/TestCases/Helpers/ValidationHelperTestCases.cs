namespace GeometryLibrary.UnitTests.TestCases.Helpers
{
    public static class ValidationHelperTestCases
    {
        public static List<TestCaseData> ThrowIfOutOfNormalPositiveRange_PositiveTestCases()
        {
            var cases = new List<TestCaseData>
            {
                new(double.MaxValue),
                new(double.MaxValue/2),
                new(1),
            };

            return cases;
        }

        public static List<TestCaseData> ThrowIfOutOfNormalPositiveRange_NegativeTestCases()
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
    }
}