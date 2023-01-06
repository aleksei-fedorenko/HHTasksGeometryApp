using FluentAssertions;
using GeometryLibrary.Shapes;
using GeometryLibrary.UnitTests.TestCases.Shapes;

namespace GeometryLibrary.UnitTests.Tests.Shapes
{
    [TestFixture]
    public class TriangleTests
    {
        [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.CreateNewTriangle_PositiveTestCases))]
        public void CreateNewTriangle_PositiveTest(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            //Arrange
            var createNewTriangleAction = () => new Triangle(firstSide, secondSide, thirdSide);

            //Assert
            createNewTriangleAction.Should().NotThrow();

            var triangle = createNewTriangleAction();
            triangle.Should().NotBeNull();
            triangle.FirstSide.Should().Be(firstSide);
            triangle.SecondSide.Should().Be(secondSide);
            triangle.ThirdSide.Should().Be(thirdSide);
        }

        [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.CreateNewTriangle_NegativeTestCases))]
        public void CreateNewTriangle_NegativeTest(
            double firstSide,
            double secondSide,
            double thirdSide)
        {
            //Arrange
            var createNewTriangleAction = () => new Triangle(firstSide, secondSide, thirdSide);

            //Assert
            createNewTriangleAction.Should()
                .Throw<ArgumentOutOfRangeException>();
        }

        [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.IsExists_Test))]
        public void IsExists_Test(
            double firstSide,
            double secondSide,
            double thirdSide,
            bool expectedIsExists)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var isExists = triangle.IsExists;

            //Assert
            isExists.Should().Be(expectedIsExists);
        }

        [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.CalculateArea_TestCases))]
        public void CalculateArea_Test(
            double firstSide,
            double secondSide,
            double thirdSide,
            double expectedArea,
            double precision)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var area = triangle.CalculateArea();

            //Assert
            area.Should().BeApproximately(expectedArea, precision);
        }

        [TestCaseSource(typeof(TriangleTestCases), nameof(TriangleTestCases.IsSquareness_TestCases))]
        public void IsSquareness_Test(
            double firstSide,
            double secondSide,
            double thirdSide,
            bool expectedIsSquareness)
        {
            //Arrange
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            //Act
            var isSquareness = triangle.IsSquareness();

            //Assert
            isSquareness.Should().Be(expectedIsSquareness);
        }
    }
}