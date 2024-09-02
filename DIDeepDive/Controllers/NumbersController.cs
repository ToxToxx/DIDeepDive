using DIDeepDive.Clients;
using DIDeepDive.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDeepDive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController(NumbersService _numbersService, NumbersClient _numbersClient) : ControllerBase
    {
        [HttpGet]
        public IActionResult GetNumber()
        {
            _numbersClient.Increment();
            return Ok(_numbersService.GetNumber());
        }
    }
}
