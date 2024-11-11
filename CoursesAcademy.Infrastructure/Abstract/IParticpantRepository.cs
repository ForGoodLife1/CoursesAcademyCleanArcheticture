
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IParticpantRepository : IGenericRepositoryAsync<Particpant>
    {
        public Task<List<Particpant>> GetParticpantsAsync();
    }
}
