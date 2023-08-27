using ShapeLib.API.Interfaces;
using ShapeLib.API.ShapeParameters;

namespace ShapeLib.API.Shapes;

public class Triangle : ITriangle
{
    internal Triangle(TriangleParameters parameters)
    {
        SideA = parameters.SideA;
        SideB = parameters.SideB;
        SideC = parameters.SideC;
    }
    public double SideA { get; }
    public double SideB { get; }
    public double SideC { get; }

    public required double Square { get; init; }

    public required bool IsRight { get; init; }
}
