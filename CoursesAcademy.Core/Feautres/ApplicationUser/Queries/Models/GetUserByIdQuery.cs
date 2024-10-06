using CoursesAcademy.Core.Bases;
using CoursesAcademy.Core.Features.ApplicationUser.Queries.Results;
using MediatR;

namespace CoursesAcademy.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserByIdQuery : IRequest<Response<GetUserByIdResponse>>
    {
        public int Id { get; set; }
        public GetUserByIdQuery(int id)
        {
            Id = id;
        }
    }
}
