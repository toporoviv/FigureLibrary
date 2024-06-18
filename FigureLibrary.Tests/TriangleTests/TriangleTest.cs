using FigureLibrary.Exceptions.TriangleExceptions;
using FigureLibrary.Helpers.TriangleHelpers;
using FigureLibrary.Models.Figures;

namespace FigureLibrary.Tests.TriangleTests;
public class TriangleTest
{
    [Fact]
    public void CalculateSquare_ValidSides_ShouldReturnCorrectSquare()
    {
        // Act
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;

        var triangle = new Triangle(firstSide, secondSide, thirdSide);
    
        // Arrange
        var triangleSquare = triangle.CalculateSquare();

        // Assert
        Assert.Equal(6, triangleSquare, 4);
    }

    [Theory]
    [InlineData(-5.0, 3.0, 4.0)]
    [InlineData(-5.0, -3.0, 4.0)]
    [InlineData(-5.0, -3.0, -4.0)]
    [InlineData(-5.0, 3.0, -4.0)]
    [InlineData(5.0, -3.0, -4.0)]
    [InlineData(5.0, 3.0, -4.0)]
    public void CalculateSquare_NegativeSides_ShouldThrowInvalidSideException(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        Assert.Throws<InvalidSideException>(() =>
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
        });
    }

    [Theory]
    [InlineData(3.0, 4.0, 10.0)]
    [InlineData(1.0, 15.0, 2.0)]
    [InlineData(5.0, 2.7, 1.0)]
    public void CalculateSquare_InvalidSides_ShouldThrowNotExistsTriangleException(
        double firstSide,
        double secondSide,
        double thirdSide)
    {
        Assert.Throws<NotExistsTriangleException>(() =>
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
        });
    }

    [Fact]
    public void IsRightTriangle_RightTriangleSides_ShouldReturnTrue()
    {
        // Act
        var firstSide = 3.0;
        var secondSide = 4.0;
        var thirdSide = 5.0;

        var triangle = new Triangle(firstSide, secondSide, thirdSide);
        // Arrange

        var isRightTriangle = triangle.IsRightTriangle();

        // Assert
        Assert.True(isRightTriangle);
    }
}
