using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class InstructorRepository : GenericRepositoryAsync<Instructor>, IInstructorRepository
    {
        private readonly AplicationDbContext _dbContext;

        public InstructorRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Instructor>> GetInstructorsAsync()
        {
            return await _dbContext.Instructors.ToListAsync();
        }


    }
}
