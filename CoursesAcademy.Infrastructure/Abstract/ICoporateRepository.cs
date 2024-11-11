
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface ICoporateRepository : IGenericRepositoryAsync<Coporate>
    {
        public Task<List<Coporate>> GetCoporatesAsync();
    }
}
