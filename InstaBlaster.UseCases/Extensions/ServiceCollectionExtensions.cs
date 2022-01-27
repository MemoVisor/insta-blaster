using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace InstaBlaster.UseCases.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterUseCases(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
