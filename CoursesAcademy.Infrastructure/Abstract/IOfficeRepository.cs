
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IOfficeRepository : IGenericRepositoryAsync<Office>
    {
        public Task<List<Office>> GetOfficesAsync();
    }
}
