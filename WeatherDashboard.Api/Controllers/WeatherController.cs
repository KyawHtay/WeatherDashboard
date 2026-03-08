using Microsoft.AspNetCore.Mvc;
using WeatherDashboard.Application.Services;

namespace WeatherDashboard.Api.Controllers
{
    [ApiController]
    [Route("api/weather")]
    public class WeatherController : ControllerBase
    {
        private readonly IWeatherService _service;

        public WeatherController(IWeatherService service)
        {
            _service = service;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            var result = await _service.GetWeatherAsync(city);

            if (result == null)
                return NotFound("City not found");

            return Ok(result);
        }
    }
}
