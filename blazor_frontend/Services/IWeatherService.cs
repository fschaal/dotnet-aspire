using blazor_frontend.Models;

namespace blazor_frontend.Services;

public interface IWeatherService
{
    Task<WeatherForecast[]?> GetWeatherForecast();
}