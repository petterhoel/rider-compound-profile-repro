using Microsoft.AspNetCore.Mvc;
using SharedLib;

namespace CoreApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public HelloDto Get()
        {
            return new HelloDto();
        }
    }
}