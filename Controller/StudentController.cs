using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;
using Application.Students;
using MediatR;

namespace SWAGGER_CONFIG_API.Controller
{
    [ApiController]
    [Route("v1")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentController() { }
       
        [HttpGet("students")]
        public async Task<IActionResult> GetStudent(CancellationToken cancellationToken)
        {

            var query = new GetStudentsQuery
            {
            };
            var result = await _mediator.Send(query, cancellationToken);
            return Ok(result);

        }
        

    }
}
