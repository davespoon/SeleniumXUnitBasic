using EABddTests.Pages;
using Microsoft.Extensions.DependencyInjection;
using EATestBase.Driver;

namespace EABddTests;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IDriverFixture, DriverFixture>();
        services.AddScoped<IBrowserDriver, BrowserDriver>();
        services.AddScoped<IHomePage, HomePage>();
        services.AddScoped<IProductPage, ProductPage>();

        services.UseWebDriverInitializer();
    }
}