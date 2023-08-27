using ShapeLib.API.Interfaces;

namespace ShapeLib.InternalContracts;

internal interface IShapeValidator<T> where T : IShapeParameters
{
    public void Validate(T parameters);
}
