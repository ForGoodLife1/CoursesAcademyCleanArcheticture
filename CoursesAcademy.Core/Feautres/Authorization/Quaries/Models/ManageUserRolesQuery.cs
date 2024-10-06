using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Results;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
