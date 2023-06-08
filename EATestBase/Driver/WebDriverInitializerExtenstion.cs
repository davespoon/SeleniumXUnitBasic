using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Settings;
using System.Reflection;

namespace SeleniumXUnitBasic.Driver;

public static class WebDriverInitializerExtenstion
{
    public static IServiceCollection UseWebDriverInitializer(this IServiceCollection services,
        BrowserDriver.BrowserType browserType)
    {
        services.AddSingleton(new TestSettings { BrowserType = browserType });
        return services;
    }

    public static void ReadConfig()
    {
        var configFile = File
            .ReadAllText(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location) + "/appsettings.json");
    }
}