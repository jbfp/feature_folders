using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace FeatureFolders.Web.ObsoleteFeature
{
    [Obsolete]
    public class ObsoleteFeature : IFeature
    {
        public void ConfigureServices(
            WebHostBuilderContext context,
            IServiceCollection services)
        {
            throw new NotImplementedException();
        }
    }
}
