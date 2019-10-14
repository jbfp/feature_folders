using System;
using System.Threading;
using System.Threading.Tasks;

namespace FeatureFolders.Web.WeatherForecast
{
    public sealed class DefaultWeatherForecastProvider : IWeatherForecastProvider
    {
        public async Task<WeatherForecastModel?> GetForTodayAsync(
            CancellationToken cancellationToken)
        {
            var weatherForecast = new WeatherForecastModel
            {
                Date = DateTimeOffset.Now.Date,
                TemperatureC = 26,
                Summary = "Lookin' good!"
            };

            return await Task.FromResult(weatherForecast);
        }
    }
}
