using EABddTests.Pages;
using Microsoft.Extensions.DependencyInjection;
using EATestBase.Driver;
using SolidToken.SpecFlow.DependencyInjection;

namespace EABddTests;

public static class Startup
{
    // public void ConfigureServices(IServiceCollection services)
    // {
    //     services.AddScoped<IDriverFixture, DriverFixture>();
    //     services.AddScoped<IBrowserDriver, BrowserDriver>();
    //     services.AddScoped<IHomePage, HomePage>();
    //     services.AddScoped<IProductPage, ProductPage>();
    //
    //     services.UseWebDriverInitializer();
    // }

    [ScenarioDependencies]
    public static IServiceCollection CreateServices()
    {
        var services = new ServiceCollection();

        services.AddScoped<IDriverFixture, DriverFixture>();
        services.AddScoped<IBrowserDriver, BrowserDriver>();
        services.AddScoped<IHomePage, HomePage>();
        services.AddScoped<IProductPage, ProductPage>();

        services.UseWebDriverInitializer();
        return services;
    }
}