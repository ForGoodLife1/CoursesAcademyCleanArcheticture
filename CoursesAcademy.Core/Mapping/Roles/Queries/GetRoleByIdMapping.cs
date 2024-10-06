using CoursesAcademy.Core.Features.Authorization.Quaries.Responses;
using CoursesAcademy.Data.Entities.Identity;

namespace CoursesAcademy.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRoleByIdMapping()
        {
            CreateMap<Role, GetRoleByIdResponse>();
        }
    }
}
