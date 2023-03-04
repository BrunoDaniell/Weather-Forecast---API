using WeatherForecastAPI.Model;

namespace WeatherForecastAPI.Adapter
{
    public interface IWeatherForecastAdapter
    {
        public Task<ModelRoot> GetWeatherByName(string cityName);
    }
}
