
using CoursesAcademy.Data.Entities;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IIndividualRepository
    {
       public Task<List<Individual>> GetIndividualsAsync();
    }
}
