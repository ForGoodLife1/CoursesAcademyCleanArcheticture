using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class CourseRepository : GenericRepositoryAsync<Course>, ICourseRepository
    {
        private readonly AplicationDbContext _dbContext;

        public CourseRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Course>> GetCoursesAsync()
        {
            return await _dbContext.Courses.ToListAsync();
        }


    }
}
