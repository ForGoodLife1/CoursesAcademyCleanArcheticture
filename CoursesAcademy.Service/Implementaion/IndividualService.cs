using CoursesAcademy.Data.Entities;
using CoursesAcademy.Service.Abstract;

namespace CoursesAcademy.Infrastructure.Abstract
{
    public class IndividualService : IIndividualService
    {
        private readonly IIndividualRepository _individualRepository;

        public IndividualService(IIndividualRepository individualRepository) 
        {
            _individualRepository=individualRepository;
        }
         public async Task<List<Individual>> GetIndividualsAsync()
        {
            return await _individualRepository.GetIndividualsAsync();
        }

        
    }
}
