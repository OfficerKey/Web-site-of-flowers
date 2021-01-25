

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using WebApplication2.Interfaces;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using HttpGetAttribute = Microsoft.AspNetCore.Mvc.HttpGetAttribute;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace WebApplication2.Controllers
{

    [Route("/admin")]
    [ApiController]
    [Authorize]
    public class AdminPanelController : Controller
    {
        
        
        [HttpGet]
        
        public IActionResult Index()
        {
            if(User.Identity.IsAuthenticated && User.Identity.Name== "kalishvlad3@gmail.com")
            {
                return View();

            }
            else
            {
                return Redirect("/home");
            }
               
           
            
        }
        
    }
}
