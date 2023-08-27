using ShapeLib.API.Interfaces;

namespace ShapeLib.API.ShapeParameters;

public record TriangleParameters(double SideA, double SideB, double SideC) : IShapeParameters;
