using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class ParticpantRepository : GenericRepositoryAsync<Particpant>, IParticpantRepository
    {
        private readonly AplicationDbContext _dbContext;

        public ParticpantRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Particpant>> GetParticpantsAsync()
        {
            return await _dbContext.Particpants.ToListAsync();
        }


    }
}
