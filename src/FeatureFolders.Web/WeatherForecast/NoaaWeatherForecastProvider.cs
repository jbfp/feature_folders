using System.Threading;
using System.Threading.Tasks;

namespace FeatureFolders.Web.WeatherForecast
{
    public sealed class NoaaWeatherForecastProvider : IWeatherForecastProvider
    {
        public async Task<WeatherForecastModel?> GetForTodayAsync(
            CancellationToken cancellationToken)
        {
            return await Task.FromResult<WeatherForecastModel?>(null);
        }
    }
}
