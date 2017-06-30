using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace host.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("direct-stuff")]
        public IActionResult DirectStuff()
        {
            return Ok("This is your stuff directly delivered to you...");
        }

        [HttpPost]
        [Route("redirected-stuff")]
        public IActionResult RedirectedStuff()
        {
            return Redirect("/stuff");
        }

        [HttpGet]
        [Route("stuff")]
        public IActionResult Stuff()
        {
            return Ok("Stuff...");
        }
    }
}
