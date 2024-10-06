using CoursesAcademy.Core.Bases;
using CoursesAcademy.Data.Results;
using MediatR;

namespace CoursesAcademy.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
