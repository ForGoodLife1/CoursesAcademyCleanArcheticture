
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IIndividualRepository : IGenericRepositoryAsync<Individual>
    {
        public Task<List<Individual>> GetIndividualsAsync();
    }
}
