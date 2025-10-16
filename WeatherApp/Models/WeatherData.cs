using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WeatherApp.Models
{
    public class WeatherData
    {
        public string City { get; set; }= string.Empty;
        public double Temperature { get; set; }

        public int Humidity { get; set; }

        public double WindSpeed { get; set; }

        public string ErrorMessage { get; set; }= string.Empty;
    }
}
