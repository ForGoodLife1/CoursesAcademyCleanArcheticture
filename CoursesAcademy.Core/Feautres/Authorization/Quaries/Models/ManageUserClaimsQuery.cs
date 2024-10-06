using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Results;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
