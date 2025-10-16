using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;
using WeatherApp.Models;
using System.Net.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;


namespace WeatherApp.Pages
{
    public class IndexModel : PageModel
    {
       private readonly IConfiguration _configuration;
        private readonly ILogger <IndexModel> _logger;
        private readonly HttpClient _httpClient;

        public WeatherData Weather { get; set; } = new WeatherData();

        public IndexModel(IConfiguration configuration, ILogger<IndexModel> logger, HttpClient httpClient)
        {
            _configuration = configuration;
            _logger = logger;
            _httpClient = httpClient;
        }

        public void OnGet()
        {
        }

        public async Task OnPostAsync(string city)
        {
            if (string.IsNullOrEmpty(city))
            {
                Weather.ErrorMessage = "Please enter the city";
                return;
            }

            var apiKey = _configuration["OpenWeatherMapApiKey"];
            _logger.LogInformation("Loaded Api Key length : {Length}", apiKey?.Length ?? 0);
            if (string.IsNullOrEmpty(apiKey) || apiKey.Length !=32)
            {
                Weather.ErrorMessage = "API Key is missing or invalid in config!";
                return;
            }
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={apiKey}&units=metric";

            try
            {

                var response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    var data = JsonSerializer.Deserialize<WeatherResponse>(json);

                    Weather.City = data?.name ?? city;
                    Weather.Temperature = data?.main?.temp ?? 0;
                    Weather.Humidity = data?.main?.humidity ?? 0;
                    Weather.WindSpeed = data?.wind?.speed ?? 0;
                }

                else
                {
                    Weather.ErrorMessage = $"Error : {response.StatusCode}";
                }



            }
            catch (Exception ex)
            {
                Weather.ErrorMessage = $"Error : {ex.Message}";
            }
            
        }


    }

    public class WeatherResponse
    {
        public Main main { get; set; }
        public Wind wind { get; set; }
        public string name { get; set; }
    }

    public class Main
    {
        public double temp { get; set; }
        public int humidity { get; set; }
    }

    public class Wind
    {
        public double speed { get; set; }
    }
}
