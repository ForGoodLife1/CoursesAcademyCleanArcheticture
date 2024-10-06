using CoursesAcademy.Core.Bases;
using MediatR;

namespace CoursesAcademy.Core.Features.Authentication.Queries.Models
{
    public class ConfirmResetPasswordQuery : IRequest<Response<string>>
    {
        public string Code { get; set; }
        public string Email { get; set; }
    }
}
