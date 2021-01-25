using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    [Route("login")]
    [ApiController]
    public class LoginController:Controller
    {
        private readonly IConfiguration _configuration;

        public LoginController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        
        public ActionResult Login([FromForm] User user)
        {
            if (ModelState.IsValid && user != null &&  !(string.IsNullOrEmpty(user.email)) && !(string.IsNullOrEmpty(user.password)))
            {

                string password = null;
                string mail = null;
                string query = @"select email,password from dbo.Users where email= '"+user.email+@"'";

                DataTable table = new DataTable();
                string sqlDataSource = _configuration.GetConnectionString("CommandsConnection");
                SqlDataReader myReader;

                using (SqlConnection myCon = new SqlConnection(sqlDataSource))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query, myCon))
                    {
                        myReader = myCommand.ExecuteReader();
                        table.Load(myReader);

                        myReader.Close();
                        myCon.Close();
                    }
                }
                foreach(DataRow item in table.Rows)
                {
                    mail = (string)item["email"];
                    password = (string)item["password"];
                }
                
                
                if (user.email==mail && password==user.password)
                {
                    Authenticate(user.email);


                    return RedirectToAction("Home", "Home");
                }
                else
                    {
                    ModelState.AddModelError("", "Данные внесенны не правильно");
                    return View(user);
                }


                

            }
            else
            {
                ModelState.AddModelError("","Данные внесенны не правильно");
                return View(user);
            }
        }

        private async Task Authenticate(string userName)
        {
            // создаем один claim
            var claims = new List<Claim>
            {
                new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
            };
            // создаем объект ClaimsIdentity
            ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
            // установка аутентификационных куки
            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
        }
        
        
        
    }
}
