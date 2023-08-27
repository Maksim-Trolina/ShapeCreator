namespace ShapeLib.API.Exceptions;

public class InvalidShapeParameters : Exception
{
    public InvalidShapeParameters(string message) : base(message) { }
    public InvalidShapeParameters(string message, Exception innerException) : base(message, innerException) { }
}
