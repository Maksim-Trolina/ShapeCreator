using ShapeLib.API.ShapeParameters;

namespace ShapeLib.InternalContracts.ShapeAlgorithms;

internal interface ITriangleAlgorithms
{
    public double CalculateSquare(TriangleParameters parameters);
    public bool IsRight(TriangleParameters parameters);
}
