using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;

namespace ShapeLib.API.Interfaces;

public interface IShapeCreator
{
    public Circle CalculateCircle(CircleParameters parameters);
    public Triangle CalculateTriangle(TriangleParameters parameters);
}
