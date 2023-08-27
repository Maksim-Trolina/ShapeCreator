using ShapeLib.API.ShapeParameters;
using ShapeLib.InternalContracts.ShapeAlgorithms;

namespace ShapeLib.ShapeAlgorithms;

internal class TriangleAlgorithms : ITriangleAlgorithms
{
    public double CalculateSquare(TriangleParameters parameters)
    {
        double sideA = parameters.SideA;
        double sideB = parameters.SideB;
        double sideC = parameters.SideC;

        double semiPerimeter = (sideA + sideB + sideC) / 2;
        double square = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA)
            * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        return square;
    }

    public bool IsRight(TriangleParameters parameters)
    {
        double sideA = parameters.SideA;
        double sideB = parameters.SideB;
        double sideC = parameters.SideC;

        double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);
        double sumOfSquares = sideA * sideA + sideB * sideB + sideC * sideC;

        return sumOfSquares == maxSide * maxSide * 2;
    }
}
