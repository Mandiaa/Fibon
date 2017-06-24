
    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
    
    public class HomeController : Controller
    {
        // GET api/values
        [HttpGet("")]
        public IActionResult Get()
        {
            return Content("Hello world controller");
        }

    }