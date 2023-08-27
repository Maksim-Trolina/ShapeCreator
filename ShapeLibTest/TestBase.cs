using Microsoft.Extensions.DependencyInjection;
using ShapeLib.API.Extensions;

namespace ShapeLibTest;

[SetUpFixture]
internal abstract class TestBase
{
    protected IServiceProvider ServiceProvider { get; private set; }
    [OneTimeSetUp]
    public void GlobalSetUp()
    {
        var serviceCollection = new ServiceCollection();
        ServiceProvider = RegisterServices(serviceCollection)
            .BuildServiceProvider();
    }

    protected virtual IServiceCollection RegisterServices(IServiceCollection services)
    {
        return services
            .AddShapeLib();
    }
}
