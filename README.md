🌦 Weather Dashboard

A full-stack Weather Dashboard application built using ASP.NET Core (.NET 8) and React.

The application allows users to search for weather information by city and display key weather details including:

Temperature

Humidity

Wind speed

Weather icon

Weather data is retrieved from the OpenWeatherMap API.

📸 Screenshots
Weather Dashboard UI

<img width="671" height="596" alt="image" src="https://github.com/user-attachments/assets/138241ac-e459-490e-a3bf-2bea8df4fd21" />


🏗 Architecture

The backend follows Clean Architecture and SOLID principles to ensure separation of concerns.

<img width="520" height="922" alt="mermaid-diagram" src="https://github.com/user-attachments/assets/5cc9757a-5533-4bf5-bb7a-9267f15db714" />

Layer Responsibilities
| Layer              | Responsibility                      |
| ------------------ | ----------------------------------- |
| **API**            | HTTP endpoints and request handling |
| **Application**    | Business logic                      |
| **Domain**         | Core models and interfaces          |
| **Infrastructure** | External API integration            |
| **Frontend**       | User interface and interaction      |

🧰 Tech Stack
Backend

.NET 8 ASP.NET Core Web API

Repository Pattern

Dependency Injection

HttpClientFactory

Swagger

NUnit

Frontend

React

React Hooks

Axios

LocalStorage

CSS

📁 Project Structure

WeatherDashboard
│
├── backend
│   ├── WeatherDashboard.Api
│   │   ├── Controllers
│   │   ├── Program.cs
│   │   └── appsettings.json
│   │
│   ├── WeatherDashboard.Application
│   │   └── Services
│   │
│   ├── WeatherDashboard.Domain
│   │   ├── Models
│   │   └── Interfaces
│   │
│   ├── WeatherDashboard.Infrastructure
│   │   └── Repositories
│   │
│   └── WeatherDashboard.Tests
│
├── frontend
│   └── weather-dashboard-ui
│       ├── components
│       ├── services
│       └── App.js
│
└── README.md

⚙️ Setup Instructions
1️⃣ Clone Repository
git clone https://github.com/kyawHtay/weather-dashboard.git
cd weather-dashboard
🚀 Backend Setup

Navigate to the backend API project:
cd backend/WeatherDashboard.Api

Restore packages and run the API:
dotnet restore
dotnet run

Swagger UI will be available at:
https://localhost:7113/swagger


🔑 OpenWeather API Key

Create a free API key:

https://openweathermap.org/api

Add the key in appsettings.json

{
  "OpenWeather": {
    "ApiKey": "YOUR_API_KEY"
  }
}
