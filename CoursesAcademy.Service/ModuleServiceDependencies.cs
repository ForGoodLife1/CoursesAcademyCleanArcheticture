using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Service.Abstract;
using CoursesAcademy.Service.Abstracts;
using CoursesAcademy.Service.AuthServices.Implementations;
using CoursesAcademy.Service.AuthServices.Interfaces;
using CoursesAcademy.Service.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace CoursesAcademy.Service
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IIndividualService, IndividualService>();
            services.AddTransient<ICoporateService, CoporateService>();
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<IInstructorService, InstructorService>();
            services.AddTransient<IOfficeService, OfficeService>();
            services.AddTransient<IParticpantService, ParticpantService>();
            services.AddTransient<IReviewService, ReviewService>();
            services.AddTransient<IScheduleService, ScheduleService>();
            services.AddTransient<ISectionService, SectionService>();
            services.AddTransient<IAuthenticationService, AuthenticationService>();
            services.AddTransient<IAuthorizationService, AuthorizationService>();
            services.AddTransient<IEmailsService, EmailsService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<ICurrentUserService, CurrentUserService>();
            services.AddTransient<IFileService, FileService>();
            return services;
        }

    }
}
