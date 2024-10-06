using CoursesAcademy.Core.Features.ApplicationUser.Commands.Models;
using CoursesAcademy.Data.Entities.Identity;

namespace CoursesAcademy.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void AddUserMapping()
        {
            CreateMap<AddUserCommand, User>();
        }
    }
}