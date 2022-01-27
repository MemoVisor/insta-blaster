using InstaBlaster.Infrastructure.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace InstaBlaster.Infrastructure.Implementations.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IInstagramPageParser, InstagramParser>();
        }
    }
}
