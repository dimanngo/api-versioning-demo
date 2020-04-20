using Microsoft.AspNetCore.Mvc;

namespace api_versioning_demo.Controllers.urlVersion
{
    [Route("api/employee")]
    [ApiController]
    [Route("api/{v:apiVersion}/employee")]
    public class EmployeeV1Controller : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return  new OkObjectResult("employees from v1 controller");
        }
    }
}