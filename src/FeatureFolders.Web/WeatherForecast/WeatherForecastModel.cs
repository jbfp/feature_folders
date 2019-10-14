using System;

namespace FeatureFolders.Web.WeatherForecast
{
    public class WeatherForecastModel
    {
        public DateTimeOffset Date { get; set; }
        public int TemperatureC { get; set; }
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        public string? Summary { get; set; }
    }
}
