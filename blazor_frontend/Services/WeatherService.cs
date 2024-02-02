using blazor_frontend.Models;

namespace blazor_frontend.Services;

public class WeatherService: IWeatherService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<WeatherService> _logger;

    public WeatherService(HttpClient httpClient, ILogger<WeatherService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }
    
    public Task<WeatherForecast[]?> GetWeatherForecast()
    {
        _logger.LogInformation($"Getting weather forecast from backend {_httpClient.BaseAddress.AbsoluteUri}");
        return _httpClient.GetFromJsonAsync<WeatherForecast[]>("/WeatherForecast");
    }
}