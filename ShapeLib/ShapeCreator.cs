using ShapeLib.API.Interfaces;
using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.ShapeProviders;

namespace ShapeLib;

internal class ShapeCreator : IShapeCreator
{
    private readonly CircleProvider _circleProvider;
    private readonly TriangleProvider _triangleProvider;
    public ShapeCreator(CircleProvider circleProvider, TriangleProvider triangleProvider)
    {
        _circleProvider = circleProvider;
        _triangleProvider = triangleProvider;
    }

    public Circle CalculateCircle(CircleParameters parameters)
    {
        return _circleProvider.CalculateCircle(parameters);
    }

    public Triangle CalculateTriangle(TriangleParameters parameters)
    {
        return _triangleProvider.CalculateTriangle(parameters);
    }

}
