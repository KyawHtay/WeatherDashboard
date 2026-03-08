using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherDashboard.Domain.Models;

namespace WeatherDashboard.Application.Services
{
    public class WeatherService : IWeatherService
    {
        private readonly IWeatherRepository _repository;

        public WeatherService(IWeatherRepository repository)
        {
            _repository = repository;
        }

        public async Task<WeatherInfo?> GetWeatherAsync(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
                throw new ArgumentException("City cannot be empty");

            return await _repository.GetWeatherAsync(city);
        }
    }
}
