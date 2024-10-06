using CoursesAcademy.Core.Features.ApplicationUser.Queries.Results;
using CoursesAcademy.Data.Entities.Identity;

namespace CoursesAcademy.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserByIdMapping()
        {
            CreateMap<User, GetUserByIdResponse>();
        }
    }
}
