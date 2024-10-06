using CoursesAcademy.Data.Entities.Identity;

namespace CoursesAcademy.Service.Abstracts
{
    public interface IApplicationUserService
    {
        public Task<string> AddUserAsync(User user, string password);
    }
}
