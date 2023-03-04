using WeatherForecastAPI.Model;
using System.Text.Json;


namespace WeatherForecastAPI.Adapter
{
    public class WeatherForecastAdapter : IWeatherForecastAdapter
    {
        private readonly HttpClient _httpClient;

        public WeatherForecastAdapter(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ModelRoot> GetWeatherByName(string cityName)
        {
            var httpRequest = new HttpRequestMessage(HttpMethod.Get, $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=a3a5fb22e905f985dae14ed45934e850");
            var httpResponse = await _httpClient.SendAsync(httpRequest);
            var json = await httpResponse.Content.ReadAsStringAsync();
            var weatherObject = JsonSerializer.Deserialize<ModelRoot>(json);

            return weatherObject;

        }
    }
}
