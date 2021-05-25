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
            // Context
            services.AddScoped<DataContext>();

            // Aluno
            services.AddScoped<IAlunoRepository, AlunoRepository>();
            services.AddScoped<IAlunoService, AlunoService>();

            // Curso
            services.AddScoped<ICursoRepository, CursoRepository>();
            services.AddScoped<ICursoService, CursoService>();

            // Modulo
            services.AddScoped<IModuloRepository, ModuloRepository>();
            services.AddScoped<IModuloService, ModuloService>();

            // Aula

            services.AddScoped<IAulaRepository, AulaRepository>();
            services.AddScoped<IAulaService, AulaService>();

            // Assinatura
            services.AddScoped<IAssinaturaRepository, AssinaturaRepository>();
            services.AddScoped<IAssinaturaService, AssinaturaService>();

            // Pagamento
            services.AddScoped<IPagamentoRepository, PagamentoRepository>();
            services.AddScoped<IPagamentoService, PagamentoService>();

            services.AddScoped<INotificator, Notificator>();
            
            return services;
        }
    }
}
