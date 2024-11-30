using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class SectionRepository : GenericRepositoryAsync<Section>, ISectionRepository
    {
        private DbSet<Section> sections;
        public SectionRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            sections=dbContext.Set<Section>();
        }
        public async Task<List<Section>> GetSectionsAsync()
        {
            return await _dbContext.Sections.ToListAsync();
        }


    }
}
