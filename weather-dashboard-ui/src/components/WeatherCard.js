import React from "react";

function WeatherCard({ weather }) {
  if (!weather) return null;

  const iconUrl = `https://openweathermap.org/img/wn/${weather.icon}@2x.png`;

  return (
    <div className="weather-card">
      <h2>{weather.city}</h2>
      <img src={iconUrl} alt={weather.city} />
      <p><strong>Temperature:</strong> {weather.temperature}°C</p>
      <p><strong>Humidity:</strong> {weather.humidity}%</p>
      <p><strong>Wind Speed:</strong> {weather.windSpeed} m/s</p>
    </div>
  );
}

export default WeatherCard;