using CoursesAcademy.Core.Bases;
using MediatR;

namespace CoursesAcademy.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
