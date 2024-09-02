using DIDeepDive.Clients;
using DIDeepDive.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDeepDive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController(
        NumbersService _numbersService) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumber()
        {;
            return Ok(_numbersService.GetNumber());
        }
    }
}
