using FigureLibrary.Helpers.MathHelpers;
using FigureLibrary.Models.Figures;

namespace FigureLibrary.Helpers.TriangleHelpers;
public static class TriangleHelper
{
    public static bool IsRightTriangle(this Triangle triangle)
    {
        var firstSide = triangle.FirstSide;
        var secondSide = triangle.SecondSide;
        var thirdSide = triangle.ThirdSide;

        return (Math.Abs(firstSide * firstSide - (secondSide * secondSide + thirdSide * thirdSide)) < MathHelper.Eps)
            || (Math.Abs(secondSide * secondSide - (firstSide * firstSide + thirdSide * thirdSide)) < MathHelper.Eps)
            || (Math.Abs(firstSide * firstSide + secondSide * secondSide - thirdSide * thirdSide) < MathHelper.Eps);
    }
}
