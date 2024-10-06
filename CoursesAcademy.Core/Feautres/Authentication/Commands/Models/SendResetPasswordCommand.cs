using CoursesAcademy.Core.Bases;
using MediatR;

namespace CoursesAcademy.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
