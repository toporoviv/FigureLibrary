using FigureLibrary.Exceptions.TriangleExceptions;
using FigureLibrary.Helpers.MathHelpers;

namespace FigureLibrary.Models.Figures;
public class Triangle : IFigure
{
    public double FirstSide { get; }
    public double SecondSide { get; }
    public double ThirdSide { get; }

    public Triangle(double firstSide, double secondSide, double thirdSide)
    {
        if (IsValidSides(firstSide, secondSide, thirdSide))
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }
    }

    public double CalculateSquare()
    {
        var halfPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
        var square = Math.Sqrt(
            halfPerimeter *
            (halfPerimeter - FirstSide) * 
            (halfPerimeter - SecondSide) *
            (halfPerimeter - ThirdSide));

        return square;
    }

    private bool IsValidSides(double firstSide, double secondSide, double thirdSide)
    {
        if (firstSide < MathHelper.Eps
            || secondSide < MathHelper.Eps
            || thirdSide < MathHelper.Eps)
        {
            throw new InvalidSideException();
        }

        if (firstSide + secondSide < thirdSide
            || firstSide + thirdSide < secondSide
            || secondSide + thirdSide < firstSide)
        {
            throw new NotExistsTriangleException();
        }

        return true;
    }
}
