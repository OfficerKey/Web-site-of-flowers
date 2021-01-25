using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    [Route("home")]
    [ApiController]
    [Authorize]
    public class HomeController:Controller
    {
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Home()
        {

           return View();
            
        }
    }
}
