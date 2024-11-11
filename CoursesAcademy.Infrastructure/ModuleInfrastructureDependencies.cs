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
            services.AddTransient<ICoporateRepository, CoporateRepository>();
            services.AddTransient<ICourseRepository, CourseRepository>();
            services.AddTransient<IInstructorRepository, InstructorRepository>();
            services.AddTransient<IOfficeRepository, OfficeRepository>();
            services.AddTransient<IParticpantRepository, ParticpantRepository>();
            services.AddTransient<IReviewRepository, ReviewRepository>();
            services.AddTransient<IScheduleRepository, ScheduleRepository>();
            services.AddTransient<ISectionRepository, SectionRepository>();
            services.AddTransient<IRefreshTokenRepository, RefreshTokenRepository>();
            return services;
        }
    }
}
