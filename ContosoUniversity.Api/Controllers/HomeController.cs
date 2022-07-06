using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Content("Greetings!!");
        }
    }
}
