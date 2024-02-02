using blazor_frontend.Services;

namespace blazor_frontend;

public static class ConfigureServices
{
    public static void AddFrontendServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddHttpClient<IWeatherService, WeatherService>(client =>
        {
            client.BaseAddress = new Uri(configuration["BackendUrl"]);
        });
    }
}