Weather Dashboard

A full-stack application that displays weather information for a user-specified city using a React frontend and an ASP.NET Core (.NET 8) backend API. The backend integrates with the OpenWeatherMap API to fetch real-time weather data.

This project was implemented as part of a technical assessment to demonstrate clean architecture, separation of concerns, and modern development practices.

Tech Stack
Backend

.NET 8 ASP.NET Core Web API

Repository Pattern

SOLID principles

HttpClientFactory

Dependency Injection

NUnit for unit testing

Swagger for API documentation

Frontend

React (functional components)

React Hooks

Axios for API requests

LocalStorage for default location persistence

Responsive CSS

Architecture Overview

The backend follows a Clean Architecture approach with clear separation of responsibilities.

Controller
   ↓
Service (Business Logic)
   ↓
Repository (External API access)
   ↓
OpenWeatherMap API

Project structure:

WeatherDashboard
│
├── backend
│   ├── WeatherDashboard.Api
│   ├── WeatherDashboard.Application
│   ├── WeatherDashboard.Domain
│   ├── WeatherDashboard.Infrastructure
│   └── WeatherDashboard.Tests
│
├── frontend
│   └── weather-dashboard-ui
│
└── README.md
Responsibilities

Domain

Core models

Interfaces

Application

Business logic

Service layer

Infrastructure

External integrations

Repository implementation

API

Controllers

Dependency injection

Configuration

Features

Search weather by city

Display temperature, humidity, wind speed, and weather icon

Set and store default location

Load default location on application start

Error handling for invalid cities

Unit tests for backend and frontend components

Responsive layout for desktop and mobile

Setup Instructions
1. Clone repository
git clone https://github.com/your-username/weather-dashboard.git
cd weather-dashboard
Backend Setup

Navigate to backend project:

cd backend/WeatherDashboard.Api

Install dependencies and run the API:

dotnet restore
dotnet run

Swagger will be available at:

https://localhost:7113/swagger
OpenWeather API Key

Create a free API key from:

https://openweathermap.org/api

Add the key to appsettings.json

{
  "OpenWeather": {
    "ApiKey": "YOUR_API_KEY"
  }
}
Frontend Setup

Navigate to frontend project:

cd frontend/weather-dashboard-ui

Install dependencies:

npm install

Run the React application:

npm start

The app will be available at:

http://localhost:3000
API Endpoints
Get weather by city
GET /api/weather/{city}

Example:

GET /api/weather/London

Response:

{
  "city": "London",
  "temperature": 10.2,
  "humidity": 78,
  "windSpeed": 4.2,
  "icon": "04d"
}
Default Location

The frontend stores the default city using LocalStorage.

On application startup the stored location is automatically loaded and weather data is fetched.

Running Unit Tests

Backend tests:

dotnet test

Frontend tests:

npm test
Error Handling

The application handles several edge cases:

Invalid city names

External API failures

Network errors

Missing API keys

Meaningful error messages are returned by the API and displayed in the UI.

CORS Configuration

The backend enables CORS to allow the React frontend to communicate with the API:

builder.Services.AddCors(options =>
{
    options.AddPolicy("ReactFrontend",
        policy => policy.WithOrigins("http://localhost:3000")
                        .AllowAnyHeader()
                        .AllowAnyMethod());
});
Testing Approach
Backend

Service layer tested using NUnit

Repository interactions mocked where necessary

Frontend

Component rendering tests using React Testing Library

Example test coverage:

SearchBar renders correctly

WeatherCard displays weather data

Service layer returns expected results

Challenges and Design Decisions
1. External API Integration

The OpenWeatherMap API was integrated through a repository abstraction to isolate external dependencies.

2. Separation of Concerns

Clean architecture ensures that business logic is separated from infrastructure and presentation layers.

3. Error Handling

The application gracefully handles invalid city names and network issues.

4. State Management

React hooks were used for managing component state and lifecycle events.

Possible Improvements

If more time were available, the following improvements could be implemented:

Add caching (IMemoryCache) for weather responses

Implement global exception middleware

Add logging using Serilog

Deploy using Docker

Improve UI styling with Material UI or Tailwind

Add integration tests

Author

Lewis

Senior Full-Stack Developer
C# | .NET | React | Azure
