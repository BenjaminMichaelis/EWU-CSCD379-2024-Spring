using Microsoft.AspNetCore.Mvc;

namespace Wordle.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WordController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Test String";
        }
    }
}
