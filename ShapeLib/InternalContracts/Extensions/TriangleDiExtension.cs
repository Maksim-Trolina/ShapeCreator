using Microsoft.Extensions.DependencyInjection;
using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts.ShapeAlgorithms;
using ShapeLib.ShapeAlgorithms;
using ShapeLib.ShapeBuilders;
using ShapeLib.ShapeProviders;
using ShapeLib.ShapeValidators;

namespace ShapeLib.InternalContracts.Extensions;

internal static class TriangleDiExtension
{
    internal static IServiceCollection AddTriangleServices(this IServiceCollection services)
    {
        return services
            .AddSingleton<IShapeValidator<TriangleParameters>, TriangleValidator>()
            .AddSingleton<TriangleProvider, TriangleProvider>()
            .AddSingleton<IShapeBuilder<TriangleParameters, Triangle>, TriangleBuilder>()
            .AddSingleton<ITriangleAlgorithms, TriangleAlgorithms>();
    }
}
