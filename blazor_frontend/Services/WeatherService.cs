using blazor_frontend.Models;

namespace blazor_frontend.Services;

public class WeatherService: IWeatherService
{
    private readonly HttpClient _httpClient;

    public WeatherService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }
    
    public Task<WeatherForecast[]?> GetWeatherForecast()
    {
        return _httpClient.GetFromJsonAsync<WeatherForecast[]>("/WeatherForecast");
    }
}