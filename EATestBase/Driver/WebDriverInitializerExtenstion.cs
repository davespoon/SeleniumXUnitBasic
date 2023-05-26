using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.DriverService;
using SeleniumXUnitBasic.Settings;

namespace SeleniumXUnitBasic.Driver;

public static class WebDriverInitializerExtenstion
{
    public static IServiceCollection UseWebDriverInitializer(this IServiceCollection services,
        BrowserDriver.BrowserType browserType)
    {
        services.AddSingleton(new TestSettings { BrowserType = browserType });
        return services;
    }
}