
using CoursesAcademy.Data.Entities;
using CoursesAcademy.Infarastructure.InfrastructureBases;


namespace CoursesAcademy.Infrastructure.Abstract
{
    public interface IScheduleRepository : IGenericRepositoryAsync<Schedule>
    {
        public Task<List<Schedule>> GetSchedulesAsync();
    }
}
