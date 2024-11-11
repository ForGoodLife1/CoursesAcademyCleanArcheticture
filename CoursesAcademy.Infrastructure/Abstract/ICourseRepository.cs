
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface ICourseRepository : IGenericRepositoryAsync<Course>
    {
        public Task<List<Course>> GetCoursesAsync();
    }
}
