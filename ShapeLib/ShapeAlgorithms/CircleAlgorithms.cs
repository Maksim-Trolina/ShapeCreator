using ShapeLib.API.ShapeParameters;
using ShapeLib.InternalContracts.ShapeAlgorithms;

namespace ShapeLib.ShapeAlgorithms;

internal class CircleAlgorithms : ICircleAlgorithms
{
    public double CalculateSquare(CircleParameters parameters)
    {
        double radius = parameters.Radius;
        return radius * radius * Math.PI;
    }
}
