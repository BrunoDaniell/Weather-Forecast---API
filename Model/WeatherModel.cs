using System.Text.Json.Serialization;

namespace WeatherForecastAPI.Model
{
    public class WeatherModel
    {
        
        public string main { get; set; }

        public string description { get; set; }
    }
}
