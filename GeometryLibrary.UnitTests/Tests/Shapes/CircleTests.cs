using FluentAssertions;
using GeometryLibrary.Shapes;
using GeometryLibrary.UnitTests.TestCases.Shapes;

namespace GeometryLibrary.UnitTests.Tests.Shapes
{
    [TestFixture]
    public class CircleTests
    {
        [TestCaseSource(typeof(CircleTestCases), nameof(CircleTestCases.CreateNewCircle_PositiveTestCases))]
        public void CreateNewCircle_PositiveTest(double radius)
        {
            //Arrange
            var createNewCircleAction = () => new Circle(radius);

            //Assert
            createNewCircleAction.Should().NotThrow();

            var circle = createNewCircleAction();
            circle.Should().NotBeNull();
            circle.Radius.Should().Be(radius);
        }

        [TestCaseSource(typeof(CircleTestCases), nameof(CircleTestCases.CreateNewCircle_NegativeTestCases))]
        public void CreateNewCircle_NegativeTest(double radius)
        {
            //Arrange
            var createNewCircleAction = () => new Circle(radius);

            //Assert
            createNewCircleAction.Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [TestCaseSource(typeof(CircleTestCases), nameof(CircleTestCases.CalculateArea_TestCases))]
        public void CalculateArea_Test(double radius, double expectedArea, double precision)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var area = circle.CalculateArea();

            //Assert
            area.Should().BeApproximately(expectedArea, precision);
        }
    }
}