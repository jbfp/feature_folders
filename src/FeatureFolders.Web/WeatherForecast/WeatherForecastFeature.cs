using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FeatureFolders.Web.WeatherForecast
{
    public sealed class WeatherForecastFeature : IFeature
    {
        public void ConfigureServices(
            WebHostBuilderContext context,
            IServiceCollection services)
        {
            var source = context.Configuration["Source"];

            if (source == "memory")
            {
                services.AddSingleton<IWeatherForecastProvider, DefaultWeatherForecastProvider>();
            }
            else if (source == "noaa")
            {
                services.AddTransient<IWeatherForecastProvider, NoaaWeatherForecastProvider>();
            }
        }
    }
}
