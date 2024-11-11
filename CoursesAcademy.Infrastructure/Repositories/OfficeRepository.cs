using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class OfficeRepository : GenericRepositoryAsync<Office>, IOfficeRepository
    {
        private readonly AplicationDbContext _dbContext;

        public OfficeRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Office>> GetOfficesAsync()
        {
            return await _dbContext.Offices.ToListAsync();
        }


    }
}
