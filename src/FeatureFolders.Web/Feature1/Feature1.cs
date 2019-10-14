using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FeatureFolders.Web.Feature1
{
    public sealed class Feature1 : IFeature
    {
        public void ConfigureServices(
            WebHostBuilderContext context,
            IServiceCollection services)
        {
        }
    }
}
