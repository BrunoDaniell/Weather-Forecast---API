using System.Text.Json.Serialization;

namespace WeatherForecastAPI.Model
{
    public class ModelRoot
    {
        [JsonPropertyName("weather")]
        public List<WeatherModel> Weather { get; set; }
    }
}
