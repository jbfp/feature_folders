using System.Threading;
using System.Threading.Tasks;

namespace FeatureFolders.Web.WeatherForecast
{
    public interface IWeatherForecastProvider
    {
        Task<WeatherForecastModel?> GetForTodayAsync(
            CancellationToken cancellationToken);
    }
}
