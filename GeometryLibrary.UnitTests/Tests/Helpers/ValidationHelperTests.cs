using FluentAssertions;
using GeometryLibrary.Helpers;
using GeometryLibrary.UnitTests.TestCases.Helpers;

namespace GeometryLibrary.UnitTests.Tests.Helpers;

[TestFixture]
public class ValidationHelperTests
{
    [TestCaseSource(typeof(ValidationHelperTestCases),
        nameof(ValidationHelperTestCases.ThrowIfOutOfNormalPositiveRange_PositiveTestCases))]
    public void ThrowIfOutOfNormalPositiveRange_PositiveTest(double value)
    {
        //Assert
        value.ThrowIfOutOfNormalPositiveRange(nameof(value));
    }

    [TestCaseSource(typeof(ValidationHelperTestCases),
        nameof(ValidationHelperTestCases.ThrowIfOutOfNormalPositiveRange_NegativeTestCases))]
    public void ThrowIfOutOfNormalPositiveRange_NegativeTest(double value)
    {
        //Arrange
        var action = () => value.ThrowIfOutOfNormalPositiveRange(nameof(value));

        //Assert
        action.Should().Throw<ArgumentOutOfRangeException>();
    }
}