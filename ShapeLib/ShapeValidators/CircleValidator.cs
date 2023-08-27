using ShapeLib.API.Exceptions;
using ShapeLib.API.ShapeParameters;
using ShapeLib.InternalContracts;

namespace ShapeLib.ShapeValidators;

internal class CircleValidator : IShapeValidator<CircleParameters>
{
    public void Validate(CircleParameters shape)
    {
        double radius = shape.Radius;

        if (radius <= 0)
            throw new InvalidShapeParameters("Radius of circle should be grather than 0.");
    }
}
