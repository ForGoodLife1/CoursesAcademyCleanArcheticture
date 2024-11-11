using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;
using CoursesAcademy.Infrastructure.Abstract;
using CoursesAcademy.Infrastructure.AppDbContext;
using Microsoft.EntityFrameworkCore;

namespace CoursesAcademy.Infrastructure.Repositories
{
    public class ScheduleRepository : GenericRepositoryAsync<Schedule>, IScheduleRepository
    {
        private readonly AplicationDbContext _dbContext;

        public ScheduleRepository(AplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext=dbContext;
        }
        public async Task<List<Schedule>> GetSchedulesAsync()
        {
            return await _dbContext.Schedules.ToListAsync();
        }


    }
}
