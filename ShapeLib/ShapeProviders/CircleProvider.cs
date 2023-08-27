using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts;

namespace ShapeLib.ShapeProviders;

internal class CircleProvider
{
    private readonly IShapeOperator _shapeOperator;

    private readonly IShapeValidator<CircleParameters> _circleValidator;
    private readonly IShapeBuilder<CircleParameters, Circle> _circleBuilder;

    public CircleProvider(IShapeOperator shapeOperator,
        IShapeValidator<CircleParameters> circleValidator,
        IShapeBuilder<CircleParameters, Circle> circleBuilder)
    {
        _shapeOperator = shapeOperator;

        _circleValidator = circleValidator;
        _circleBuilder = circleBuilder;
    }
    public Circle CalculateCircle(CircleParameters parameters)
    {
        return _shapeOperator.CalculateShape(_circleValidator, _circleBuilder, parameters);
    }
}
