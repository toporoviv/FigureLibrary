using FigureLibrary.Exceptions.CircleExceptions;
using FigureLibrary.Helpers.MathHelpers;
using FigureLibrary.Models.Figures;

namespace FigureLibrary.Tests.CircleTests;
public class CircleTest
{
    [Fact]
    public void CalculateSquare_ValidRadius_ShouldReturnCorrectAnswer()
    {
        // Act
        var radius = 1.0;
        var circle = new Circle(radius);

        // Arrange
        var circleSquare = circle.CalculateSquare();

        // Assert
        Assert.Equal(Math.PI, circleSquare, 4);
    }

    [Theory]
    [InlineData(-5.0)]
    [InlineData(-2.0)]
    [InlineData(-2.5)]
    [InlineData(-2.75)]
    public void CalculateSquare_NegativeRadius_ShouldThrowInvalidRadiusException(double radius)
    {
        Assert.Throws<InvalidRadiusException>(() =>
        {
            var circle = new Circle(radius);
        });
    }

    [Theory]
    [InlineData(2.0)]
    [InlineData(3.0)]
    [InlineData(3.5)]
    public void CalculateSquare_InvalidRadius_ShouldThrowInvalidRadiusException(double divider)
    {
        Assert.Throws<InvalidRadiusException>(() =>
        {
            var invalidRadius = MathHelper.Eps / divider;
            var circle = new Circle(invalidRadius);
        });
    }
}
