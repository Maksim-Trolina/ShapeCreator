using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts;
using ShapeLib.InternalContracts.ShapeAlgorithms;

namespace ShapeLib.ShapeBuilders;

internal class TriangleBuilder : IShapeBuilder<TriangleParameters, Triangle>
{
    private readonly ITriangleAlgorithms _algorithms;
    public TriangleBuilder(ITriangleAlgorithms algorithms)
    {
        _algorithms = algorithms;
    }
    public Triangle Build(TriangleParameters parameters)
    {
        bool isRight = _algorithms.IsRight(parameters);
        double square = _algorithms.CalculateSquare(parameters);
        return new Triangle(parameters)
        {
            IsRight = isRight,
            Square = square
        };
    }
}
