using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;

namespace FeatureFolders.Web.WeatherForecast
{
    [ApiController]
    [Produces("application/json")]
    [Route("weatherforecast")]
    public sealed class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastProvider _provider;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(
            IWeatherForecastProvider provider,
            ILogger<WeatherForecastController> logger)
        {
            _provider = provider;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult> Get(CancellationToken cancellationToken)
        {
            var weatherForecast = await _provider.GetForTodayAsync(cancellationToken);

            if (weatherForecast == null)
            {
                return NotFound();
            }

            return Ok(weatherForecast);
        }
    }
}
