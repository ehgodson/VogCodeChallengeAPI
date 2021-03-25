using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VogCodeChallenge.API.Controllers
{
    [ApiController]
    [Route("api")]
    public class HomeController : ControllerBase
    {
        public HomeController() { }

        [HttpGet]
        [HttpGet("/")]
        public IActionResult Get() =>  Ok("api ver 1.1");
    }
}
