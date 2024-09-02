using DIDeepDive.Clients;
using DIDeepDive.Services;
using Microsoft.AspNetCore.Mvc;

namespace DIDeepDive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumbersController(
        NumbersService _numbersService,
        IEnumerable<INumbersClient> _numbersClient) : ControllerBase
    {
       
        [HttpGet("all")]
        public IActionResult GetNumber()
        {
            return Ok(_numbersService.GetNumber());
        }

        [HttpGet("one")]
        public IActionResult GetNumberOne()
        {         
            return Ok(_numbersClient.Single(x => x is NumbersClient).GetNumber());
        }

        [HttpGet("three")]
        public IActionResult GetNumberThree()
        {
            return Ok(_numbersClient.Single(x => x is NumberThreeClient).GetNumber());
        }
    }
}
