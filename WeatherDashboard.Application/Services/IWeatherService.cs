using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WeatherDashboard.Domain.Models;

namespace WeatherDashboard.Application.Services
{

    public interface IWeatherService
    {
        Task<WeatherInfo?> GetWeatherAsync(string city);
    }
}