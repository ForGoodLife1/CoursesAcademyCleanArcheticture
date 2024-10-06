
using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Results;
using MediatR;

namespace CoursesAcademy.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
