using Microsoft.Extensions.DependencyInjection;
using ShapeLib.API.Exceptions;
using ShapeLib.API.Interfaces;
using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;

namespace ShapeLibTest;

[TestFixture]
internal class ShapeCreatorTests : TestBase
{
    [TestCase(2, 4 * Math.PI)]
    public void CalculateCircleWithValidDataTest(double radius, double expectedSquare)
    {        
        // Arrange
        var shapeCreator = ServiceProvider.GetRequiredService<IShapeCreator>();
        CircleParameters parameters = new(radius);

        // Act
        Circle circle = shapeCreator.CalculateCircle(parameters);

        // Assert
        Assert.That(circle.Square, Is.EqualTo(expectedSquare));
    }

    [TestCase(3, 4, 5, 6, true)]
    public void CalculateTriangleWithValidDataTest(double sideA, double sideB, double sideC, 
        double expectedSquare, bool isRightTriangleExpected)
    {
        // Arrange
        var shapeCreator = ServiceProvider.GetRequiredService<IShapeCreator>();
        TriangleParameters parameters = new(sideA, sideB, sideC);

        // Act
        Triangle triangle = shapeCreator.CalculateTriangle(parameters);

        // Assert
        Assert.That(triangle.Square, Is.EqualTo(expectedSquare));
        Assert.That(triangle.IsRight, Is.EqualTo(isRightTriangleExpected));
    }

    [TestCase(6, 3, 3)]
    [TestCase(3, 7, 3)]
    public void CalculateTriangleWithInvalidDataTest(double sideA, double sideB, double sideC)
    {
        // Arrange
        var shapeCreator = ServiceProvider.GetRequiredService<IShapeCreator>();
        TriangleParameters parameters = new(sideA, sideB, sideC);

        // Act and Assert
        Assert.Throws<InvalidShapeParameters>(() => shapeCreator.CalculateTriangle(parameters));
    }

    [TestCase(-2)]
    [TestCase(0)]
    public void CalculateCircleWithInvalidDataTest(double radius)
    {
        // Arrange
        var shapeCreator = ServiceProvider.GetRequiredService<IShapeCreator>();
        CircleParameters parameters = new(radius);

        // Act and Assert
        Assert.Throws<InvalidShapeParameters>(() => shapeCreator.CalculateCircle(parameters));
    }

}