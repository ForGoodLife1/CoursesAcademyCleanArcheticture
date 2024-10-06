using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.Repositories;
using CoursesAcademy.Infrustructure.Abstracts;
using CoursesAcademy.Infrustructure.Repositories;
using Microsoft.Extensions.DependencyInjection;


namespace CoursesAcademy.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddTransient<IIndividualRepository, IndividualRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            return services;
        }
    }
}
