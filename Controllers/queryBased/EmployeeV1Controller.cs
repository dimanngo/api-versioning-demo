using Microsoft.AspNetCore.Mvc;

namespace api_versioning_demo.Controllers.queryBased
{
    [Route("api/employee")]
    [ApiController]
    [ApiVersion("1.0")]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return  new OkObjectResult("employees from v1 controller");
        }
    }
}