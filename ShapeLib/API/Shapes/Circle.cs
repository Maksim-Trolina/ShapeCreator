using ShapeLib.API.Interfaces;
using ShapeLib.API.ShapeParameters;

namespace ShapeLib.API.Shapes;

public class Circle : IShape
{
    internal Circle(CircleParameters parameters)
    {
        Radius = parameters.Radius;
    }
    public double Radius { get; }

    public required double Square { get; init; }
}
