using EATestProject.Pages;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SeleniumXUnitBasic.Driver;

namespace EATestProject;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        var browserSetting = config.GetSection("BrowserType").Value;
        var browser = Enum.Parse(typeof(BrowserDriver.BrowserType), browserSetting);

        services.AddScoped<IDriverFixture, DriverFixture>();
        services.AddScoped<IBrowserDriver, BrowserDriver>();
        services.AddScoped<IHomePage, HomePage>();
        services.AddScoped<ICreateProductPage, CreateProductPage>();

        services.UseWebDriverInitializer((BrowserDriver.BrowserType)browser);
    }
}