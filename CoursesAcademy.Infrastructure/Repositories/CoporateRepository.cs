using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class CoporateRepository : GenericRepositoryAsync<Coporate>, ICoporateRepository
    {
        private readonly AplicationDbContext _dbContext;

        public CoporateRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Coporate>> GetCoporatesAsync()
        {
            return await _dbContext.Coporates.ToListAsync();
        }


    }
}
