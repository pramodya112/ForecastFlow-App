
![Uploading image.png…]()

🌤️ ForecastFlow

A modern, responsive weather forecast application built with ASP.NET Core Razor Pages that provides real-time weather information for cities worldwide.

![ASP.NET Core](https://img.shields.io/badge/ASP.NET%20Core-8.0-blue)
![C#](https://img.shields.io/badge/C%23-12.0-purple)
![License](https://img.shields.io/badge/license-MIT-green)

✨ Features

- 🌍 Global Weather Data - Search weather for any city worldwide
- 🎨 Modern UI - Beautiful gradient design with glassmorphic effects
- 📱 Responsive Design - Works seamlessly on desktop, tablet, and mobile devices
- ⚡ Real-time Data - Fetches live weather data from OpenWeatherMap API
- 🌡️ Comprehensive Info - Display temperature, humidity, and wind speed
- 🎭 Smooth Animations - Engaging user experience with CSS animations
- ⚠️ Error Handling - User-friendly error messages and validation

🚀 Getting Started

Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or higher
- OpenWeatherMap API Key (free at [openweathermap.org](https://openweathermap.org/api))
- A code editor (Visual Studio, VS Code, or Rider)

Installation

1. Clone the repository
   ```bash
   git clone https://github.com/yourusername/weather-forecast-app.git
   cd weather-forecast-app
   ```

2. Get your API Key
   - Sign up at [OpenWeatherMap](https://openweathermap.org/api)
   - Generate a free API key from your account dashboard

3. Configure the API Key
   
   Update `appsettings.json` with your API key:
   ```json
   {
     "OpenWeatherMapApiKey": "your_api_key_here"
   }
   ```

4. Restore dependencies
   ```bash
   dotnet restore
   ```

5. Run the application
   ```bash
   dotnet run
   ```

6. Open your browser
   
   Navigate to `https://localhost:5001` or the URL shown in your terminal

📁 Project Structure

```
WeatherApp/
├── Models/
│   └── WeatherData.cs          # Weather data model
├── Pages/
│   ├── Index.cshtml            # Main page UI
│   ├── Index.cshtml.cs         # Page logic and API integration
│   └── Shared/
│       └── _Layout.cshtml      # Layout template
├── Program.cs                  # Application entry point
├── appsettings.json            # Configuration file
└── appsettings.Development.json
```

🛠️ Technologies Used

- ASP.NET Core 8.0 - Web framework
- Razor Pages - Server-side rendering
- C# 12 - Programming language
- HttpClient - HTTP requests
- OpenWeatherMap API - Weather data provider
- CSS3 - Modern styling with gradients and animations
- HTML5 - Semantic markup

📊 API Integration

This app uses the [OpenWeatherMap Current Weather Data API](https://openweathermap.org/current):

- **Endpoint**: `api.openweathermap.org/data/2.5/weather`
- **Parameters**: City name, API key, units (metric)
- **Response**: JSON with temperature, humidity, wind speed, and more

🎨 UI Features

- Gradient Background - Purple to blue gradient for visual appeal
- Glassmorphism - Frosted glass effect on cards
- Grid Layout - Organized display of weather metrics
- Hover Effects - Interactive weather information cards
- Responsive Design - Mobile-first approach
- Smooth Animations - Slide-in effects for results

🔧 Configuration

API Key Setup

You can configure the API key in multiple ways:

1. appsettings.json (Development)
   ```json
   {
     "OpenWeatherMapApiKey": "your_api_key_here"
   }
   ```

2. Environment Variables (Production)
   ```bash
   export OpenWeatherMapApiKey="your_api_key_here"
   ```

3. User Secrets (Recommended for development)
   ```bash
   dotnet user-secrets init
   dotnet user-secrets set "OpenWeatherMapApiKey" "your_api_key_here"
   ```

🐛 Troubleshooting

Common Issues

"API Key is missing or invalid in config!"
- Ensure your API key is exactly 32 characters
- Check that the configuration key name matches: `OpenWeatherMapApiKey`
- Verify the API key is active on OpenWeatherMap

"Error: 401 Unauthorized"
- Your API key may not be activated yet (can take a few minutes)
- Verify you're using the correct API key

"Error: 404 Not Found"
- Check the city name spelling
- Try using city names in English

📈 Future Enhancements

- [ ] 5-day weather forecast
- [ ] Weather icons based on conditions
- [ ] Geolocation support
- [ ] Temperature unit conversion (Celsius/Fahrenheit)
- [ ] Search history
- [ ] Weather alerts and notifications
- [ ] Multiple city comparison
- [ ] Dark/Light theme toggle

📝 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

👤 Author

- GitHub: https://github.com/pramodya112
- LinkedIn: https://www.linkedin.com/in/pramodya-warnakula-10682626a/

🙏 Acknowledgments

- Weather data provided by [OpenWeatherMap](https://openweathermap.org/)
- Built with [ASP.NET Core](https://dotnet.microsoft.com/apps/aspnet)
- Icons and emojis for visual enhancement

⭐ Star this repo if you find it helpful!
