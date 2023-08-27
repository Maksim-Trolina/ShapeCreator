using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts;

namespace ShapeLib.ShapeProviders;

internal class TriangleProvider
{
    private readonly IShapeValidator<TriangleParameters> _triangleValidator;
    private readonly IShapeBuilder<TriangleParameters, Triangle> _triangleBuilder;
    private readonly IShapeOperator _shapeOperator;

    public TriangleProvider(IShapeOperator shapeOperator,
        IShapeValidator<TriangleParameters> triangleValidator,
        IShapeBuilder<TriangleParameters, Triangle> triangleBuilder)
    {
        _shapeOperator = shapeOperator;

        _triangleValidator = triangleValidator;
        _triangleBuilder = triangleBuilder;
    }
    public Triangle CalculateTriangle(TriangleParameters parameters)
    {
        return _shapeOperator.CalculateShape(_triangleValidator, _triangleBuilder, parameters);
    }
}
