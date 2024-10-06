using CoursesAcademy.Core.Features.ApplicationUser.Queries.Results;
using CoursesAcademy.Core.Wrappers;
using MediatR;

namespace CoursesAcademy.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
