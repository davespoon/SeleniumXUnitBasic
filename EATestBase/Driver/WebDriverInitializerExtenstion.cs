using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;
using EATestBase.Settings;
using Microsoft.Extensions.DependencyInjection;

namespace EATestBase.Driver;

public static class WebDriverInitializerExtenstion
{
    public static IServiceCollection UseWebDriverInitializer(this IServiceCollection services)
    {
        services.AddSingleton(ReadTestSettings());
        return services;
    }

    public static TestSettings ReadTestSettings()
    {
        string configFile = File
            .ReadAllText(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location) + "/appsettings.json");

        var jsonOptions = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true,
        };
        jsonOptions.Converters.Add(new JsonStringEnumConverter());

        return JsonSerializer.Deserialize<TestSettings>(configFile, jsonOptions);
    }
}