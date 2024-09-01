using Microsoft.AspNetCore.Mvc;

namespace DIDeepDive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumber()
        {
            return Ok(5);
        }
    }
}
