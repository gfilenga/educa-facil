using EducaFacil.Infra.Context;
using Microsoft.Extensions.DependencyInjection;

namespace EducaFacil.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();

            return services;
        }
    }
}
