using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Middleware.Controller
{
  
    public class LoggingController : ControllerBase
    {
        [Route("api/Log")]
        [HttpGet]
        public async Task<IActionResult> GetLog()
        {
            return Ok("Hello");
        }
    }
}
