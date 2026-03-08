import React, { useEffect, useState } from "react";
import SearchBar from "./components/SearchBar";
import WeatherCard from "./components/WeatherCard";
import DefaultLocation from "./components/DefaultLocation";
import {
  getWeatherByCity,
  getDefaultWeather,
  setDefaultCity,
} from "./services/weatherService";
import "./App.css";

function App() {
  const [weather, setWeather] = useState(null);
  const [error, setError] = useState("");
  const [loading, setLoading] = useState(false);

  const loadDefaultWeather = async () => {
    try {
      setLoading(true);
      setError("");
      const data = await getDefaultWeather();
      setWeather(data);
    } catch (err) {
      setWeather(null);
      setError("Failed to load default weather.");
    } finally {
      setLoading(false);
    }
  };

  const handleSearch = async (city) => {
    try {
      setLoading(true);
      setError("");
      const data = await getWeatherByCity(city);
      setWeather(data);
    } catch (err) {
      setWeather(null);
      setError("City not found or weather service unavailable.");
    } finally {
      setLoading(false);
    }
  };

  const handleSetDefault = async (city) => {
    setDefaultCity(city);
    await handleSearch(city);
  };

  useEffect(() => {
    loadDefaultWeather();
  }, []);

  return (
    <div className="app-container">
      <h1>Weather Dashboard</h1>
      <DefaultLocation onSetDefault={handleSetDefault} />
      <SearchBar onSearch={handleSearch} loading={loading} />
      {error && <div className="error-message">{error}</div>}
      <WeatherCard weather={weather} />
    </div>
  );
}

export default App;