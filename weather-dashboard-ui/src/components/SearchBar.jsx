import axios from "axios";

const API_BASE_URL = "https://localhost:7113/api/weather";

export const getWeatherByCity = async (city) => {
  const response = await axios.get(`${API_BASE_URL}/${encodeURIComponent(city)}`);
  return response.data;
};

export const getDefaultWeather = async () => {
  const defaultCity = localStorage.getItem("defaultCity") || "London";
  const response = await axios.get(`${API_BASE_URL}/${encodeURIComponent(defaultCity)}`);
  return response.data;
};

export const setDefaultCity = (city) => {
  localStorage.setItem("defaultCity", city);
};