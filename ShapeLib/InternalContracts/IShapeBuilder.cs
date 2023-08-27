using ShapeLib.API.Interfaces;

namespace ShapeLib.InternalContracts;

internal interface IShapeBuilder<Parameters, Shape> 
    where Parameters : IShapeParameters 
    where Shape : IShape
{
    public Shape Build(Parameters parameters);
}
