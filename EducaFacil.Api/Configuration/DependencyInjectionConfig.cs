using EducaFacil.Domain.Repositories;
using EducaFacil.Infra.Context;
using EducaFacil.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace EducaFacil.Api.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<DataContext>();
            services.AddScoped<IAlunoRepository, AlunoRepository>();

            return services;
        }
    }
}
