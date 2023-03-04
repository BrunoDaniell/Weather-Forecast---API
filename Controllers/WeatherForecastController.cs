using Microsoft.AspNetCore.Mvc;
using WeatherForecastAPI.Adapter;
using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Controllers
{
    [ApiController]
    [Route("")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IWeatherForecastAdapter _weatherForecastAdapter;

        public WeatherForecastController(IWeatherForecastAdapter weatherForecastAdapter)
        {
            _weatherForecastAdapter = weatherForecastAdapter;
        }
        [HttpGet]
        public async Task<ModelRoot> GetWeather(string cityName)
        {
            var weatherData = await _weatherForecastAdapter.GetWeatherByName(cityName);
            return weatherData;
        }
    }
}
