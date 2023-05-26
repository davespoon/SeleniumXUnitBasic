using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Driver;
using SeleniumXUnitBasic.DriverService;

namespace SeleniumXUnitBasic;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddScoped<IDriverFixture, DriverFixture>();
        services.AddScoped<IBrowserDriver, BrowserDriver>();
        services.UseWebDriverInitializer(BrowserDriver.BrowserType.Chrome);
    }
}