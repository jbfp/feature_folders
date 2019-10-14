using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace FeatureFolders.Web
{
    public interface IFeature
    {
        void ConfigureServices(
            WebHostBuilderContext context,
            IServiceCollection services);
    }
}
