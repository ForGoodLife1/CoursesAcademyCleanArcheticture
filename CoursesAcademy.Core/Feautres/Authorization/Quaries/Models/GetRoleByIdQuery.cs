using CoursesAcademy.Core.Bases;
using CoursesAcademy.Core.Features.Authorization.Quaries.Responses;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Quaries.Models
{
    public class GetRoleByIdQuery : IRequest<Response<GetRoleByIdResponse>>
    {
        public int Id { get; set; }
    }
}
