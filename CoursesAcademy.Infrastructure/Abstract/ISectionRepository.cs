
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface ISectionRepository : IGenericRepositoryAsync<Section>
    {
        public Task<List<Section>> GetSectionsAsync();
    }
}
