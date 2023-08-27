using ShapeLib.API.Exceptions;
using ShapeLib.API.ShapeParameters;
using ShapeLib.InternalContracts;

namespace ShapeLib.ShapeValidators;

internal class TriangleValidator : IShapeValidator<TriangleParameters>
{
    public void Validate(TriangleParameters shape)
    {
        double sideA = shape.SideA;
        double sideB = shape.SideB;
        double sideC = shape.SideC;

        double maxSide = Math.Max(Math.Max(sideA, sideB), sideC);
        double sumOfSidesWithoutMaxSide = sideA + sideB + sideC - maxSide;

        if (maxSide >= sumOfSidesWithoutMaxSide)
            throw new InvalidShapeParameters("Max side of triangle should be less than sum of others sides.");
    }
}
