using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Structures;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("test")]
    public class WeatherForecastController : Controller
    {
        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("index")]

        public async Task<IActionResult> Index()
        {
            return this.Json(new { result = "Hello World" });
        }

        [HttpPost]
        [HttpGet]
        [Produces("application/json")]
        [Route("hello_world")]

        public async Task<IActionResult> Test()
        {
            MyClassResponce res = new MyClassResponce();
            res.Success = "Success";
            res.Result = "Hello_world!";
            res.Version = "1.0";
            return this.Json(res);
        }
    }
}
