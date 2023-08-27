using ShapeLib.API.Interfaces;

namespace ShapeLib.InternalContracts;

internal interface IShapeOperator
{
    public Shape CalculateShape<Shape, Parameter>(IShapeValidator<Parameter> shapeValidator,
        IShapeBuilder<Parameter, Shape> shapeBuilder, Parameter parameters)
        where Shape : IShape
        where Parameter : IShapeParameters;
}
