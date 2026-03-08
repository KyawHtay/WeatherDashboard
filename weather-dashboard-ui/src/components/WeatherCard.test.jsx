import { render, screen } from "@testing-library/react";
import WeatherCard from "./WeatherCard";

test("renders weather details", () => {
  const weather = {
    city: "London",
    temperature: 12,
    humidity: 70,
    windSpeed: 5,
    icon: "04d",
  };

  render(<WeatherCard weather={weather} />);

  expect(screen.getByText("London")).toBeInTheDocument();
  expect(screen.getByText(/Temperature:/)).toBeInTheDocument();
  expect(screen.getByText(/Humidity:/)).toBeInTheDocument();
  expect(screen.getByText(/Wind Speed:/)).toBeInTheDocument();
});