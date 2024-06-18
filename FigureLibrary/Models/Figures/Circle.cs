using FigureLibrary.Exceptions.CircleExceptions;
using FigureLibrary.Helpers.MathHelpers;

namespace FigureLibrary.Models.Figures;
public class Circle : IFigure
{
    public double Radius { get; }

    public Circle(double radius = default)
    {
        if (IsValidRadius(radius))
        {
            Radius = radius;
        }
    }

    public double CalculateSquare()
    {
        return Math.PI * Radius * Radius;
    }

    private bool IsValidRadius(double radius)
    {
        if (radius < MathHelper.Eps)
        {
            throw new InvalidRadiusException();
        }

        return true;
    }
}
