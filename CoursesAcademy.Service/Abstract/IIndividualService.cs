
using CoursesAcademy.Data.Entities;


namespace CoursesAcademy.Service.Abstract
{
    public interface IIndividualService
    {
       public Task<List<Individual>> GetIndividualsAsync();
    }
}
