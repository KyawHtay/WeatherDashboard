using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WeatherDashboard.Domain.Models;

namespace WeatherDashboard.Infrastructure.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public WeatherRepository(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<WeatherInfo?> GetWeatherAsync(string city)
        {
            var apiKey = _configuration["OpenWeather:ApiKey"];
            var url =
                $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return null;

            var json = await response.Content.ReadAsStringAsync();

            dynamic data = JsonConvert.DeserializeObject(json);

            return new WeatherInfo
            {
                City = data.name,
                Temperature = data.main.temp,
                Humidity = data.main.humidity,
                WindSpeed = data.wind.speed,
                Icon = data.weather[0].icon
            };
        }
    }
}
