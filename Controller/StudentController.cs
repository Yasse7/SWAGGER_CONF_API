using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using RouteAttribute = Microsoft.AspNetCore.Components.RouteAttribute;

namespace SWAGGER_CONFIG_API.Controller
{
    [ApiController]
    [Route("v1")]
    public class StudentController : ControllerBase
    {
        public StudentController() { }
        //v1
        [HttpGet("version")]
        public int GetVersion() { return 1; }
        //v1
        [HttpPost("post")]
        public int PostVersion([FromBody] PostSt version) { return version.Id; }

    }
    public class PostSt
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public float version { get; set; }
    }
}
