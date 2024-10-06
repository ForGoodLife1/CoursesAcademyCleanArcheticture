

using CoursesAcademy.Data;
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class IndividualRepository : IIndividualRepository
    {
        private readonly AplicationDbContext _dbContext;

        public IndividualRepository(AplicationDbContext dbContext) 
        {
            _dbContext=dbContext;
        }
         public async Task<List<Individual>> GetIndividualsAsync()
        {
            return await _dbContext.Individuals.ToListAsync();
        }

        
    }
}
