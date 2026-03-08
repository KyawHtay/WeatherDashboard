namespace WeatherDashboard.Domain.Models;

public class WeatherInfo
{
    public string City { get; set; } = "";
    public double Temperature { get; set; }
    public int Humidity { get; set; }
    public double WindSpeed { get; set; }
    public string Icon { get; set; } = "";
}