using ShapeLib.API.Interfaces;
using ShapeLib.InternalContracts;

namespace ShapeLib.ShapeOperators;

internal class ShapeOperator : IShapeOperator
{
    public Shape CalculateShape<Shape, Parameter>(IShapeValidator<Parameter> shapeValidator,
        IShapeBuilder<Parameter, Shape> shapeBuilder, Parameter parameters)
        where Shape : IShape
        where Parameter : IShapeParameters
    {
        shapeValidator.Validate(parameters);
        Shape shape = shapeBuilder.Build(parameters);
        return shape;
    }
}