using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts;
using ShapeLib.InternalContracts.ShapeAlgorithms;

namespace ShapeLib.ShapeBuilders;

internal class CircleBuilder : IShapeBuilder<CircleParameters, Circle>
{
    private readonly ICircleAlgorithms _algorithms;
    public CircleBuilder(ICircleAlgorithms algorithms)
    {
        _algorithms = algorithms;
    }
    public Circle Build(CircleParameters parameters)
    {
        double square = _algorithms.CalculateSquare(parameters);
        return new Circle(parameters)
        {
            Square = square
        };
    }
}
