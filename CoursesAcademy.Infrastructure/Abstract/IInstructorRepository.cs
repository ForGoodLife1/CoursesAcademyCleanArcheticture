
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IInstructorRepository : IGenericRepositoryAsync<Instructor>
    {
        public Task<List<Instructor>> GetInstructorsAsync();
    }
}
