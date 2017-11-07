using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RESTful.Controllers
{
    // [Route("/[controller]")]
    [Route("/")]
    public class HomeController : Controller
    {
        // GET
        [HttpGet]
        public string Get()
        {
            return "This the landing page. Instructions will be forthcoming.";
        }

    }
}
