using Moq;
using WeatherDashboard.Application.Services;
using WeatherDashboard.Domain.Models;

namespace WeatherDashboard.Tests
{
    [TestFixture]
    public class WeatherServiceTests
    {
        private Mock<IWeatherRepository> _repoMock;
        private WeatherService _service;

        [SetUp]
        public void Setup()
        {
            _repoMock = new Mock<IWeatherRepository>();
            _service = new WeatherService(_repoMock.Object);
        }

        [Test]
        public async Task Should_Return_Weather()
        {
            var weather = new WeatherInfo { City = "London" };

            _repoMock.Setup(x => x.GetWeatherAsync("London"))
                .ReturnsAsync(weather);

            var result = await _service.GetWeatherAsync("London");

            Assert.That(result.City, Is.EqualTo("London"));
        }
    }
}