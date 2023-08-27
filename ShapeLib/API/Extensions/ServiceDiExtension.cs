using Microsoft.Extensions.DependencyInjection;
using ShapeLib.API.Interfaces;
using ShapeLib.InternalContracts;
using ShapeLib.InternalContracts.Extensions;
using ShapeLib.ShapeOperators;

namespace ShapeLib.API.Extensions;

public static class ServiceDiExtension
{
    public static IServiceCollection AddShapeLib(this IServiceCollection services)
    {
        return services
            .AddTriangleServices()
            .AddCircleServices()
            .AddSingleton<IShapeCreator, ShapeCreator>()
            .AddSingleton<IShapeOperator, ShapeOperator>();
    }
}
