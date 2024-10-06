using CoursesAcademy.Api.Base;
using CoursesAcademy.Core.Feautres.IndividualCQRS.Queries.ModelsQueries;
using Microsoft.AspNetCore.Mvc;

namespace CoursesAcademy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualController : AppControllerBase
    {

        [HttpGet("Individual/List")]
        public async Task<IActionResult> GetIndividualList()
        {
            var response = await Mediator.Send(new GetIndividualListQuery());
            return Ok(response);
        }
    }
}
