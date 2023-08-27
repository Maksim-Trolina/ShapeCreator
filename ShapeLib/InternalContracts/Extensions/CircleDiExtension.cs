using Microsoft.Extensions.DependencyInjection;
using ShapeLib.API.ShapeParameters;
using ShapeLib.API.Shapes;
using ShapeLib.InternalContracts.ShapeAlgorithms;
using ShapeLib.ShapeAlgorithms;
using ShapeLib.ShapeBuilders;
using ShapeLib.ShapeProviders;
using ShapeLib.ShapeValidators;

namespace ShapeLib.InternalContracts.Extensions;

internal static class CircleDiExtension
{
    internal static IServiceCollection AddCircleServices(this IServiceCollection services)
    {
        return services
            .AddSingleton<IShapeValidator<CircleParameters>, CircleValidator>()
            .AddSingleton<CircleProvider, CircleProvider>()
            .AddSingleton<IShapeBuilder<CircleParameters, Circle>, CircleBuilder>()
            .AddSingleton<ICircleAlgorithms, CircleAlgorithms>();
    }
}
