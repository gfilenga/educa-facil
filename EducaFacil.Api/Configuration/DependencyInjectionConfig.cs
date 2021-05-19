using EducaFacil.Domain.Interfaces;
using EducaFacil.Domain.Notifications;
using EducaFacil.Domain.Repositories;
using EducaFacil.Domain.Services;
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

            services.AddScoped<INotificator, Notificator>();
            services.AddScoped<IAlunoService, AlunoService>();

            return services;
        }
    }
}
