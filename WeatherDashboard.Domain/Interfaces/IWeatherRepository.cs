using WeatherDashboard.Domain.Models;

public interface IWeatherRepository
{
    Task<WeatherInfo?> GetWeatherAsync(string city);
}