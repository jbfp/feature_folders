using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;
using System.Linq;

namespace FeatureFolders.Web
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();

                    var features = typeof(Program).Assembly.DefinedTypes
                        .Where(type => type.ImplementedInterfaces.Contains(typeof(IFeature)))
                        .Where(type => !type.CustomAttributes.Any(attr => attr.AttributeType == typeof(ObsoleteAttribute)))
                        .Select(type => Activator.CreateInstance(type))
                        .Cast<IFeature>();

                    foreach (var feature in features)
                    {
                        webBuilder.ConfigureServices(feature.ConfigureServices);
                    }
                });
    }
}
