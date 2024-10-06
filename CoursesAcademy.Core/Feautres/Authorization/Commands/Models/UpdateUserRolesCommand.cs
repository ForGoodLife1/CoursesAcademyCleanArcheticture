using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Requests;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
