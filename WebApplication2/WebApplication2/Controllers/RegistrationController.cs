using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using WebApplication2.Models;
using WebApplication2.ViewModel;

namespace WebApplication2.Controllers
{
    [Route("regist")]
    [ApiController]
    public class RegistrationController: Controller
    {
        private readonly IConfiguration _configuration;

        public RegistrationController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        [HttpGet]
        public IActionResult Reg()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reg([FromForm]User user)
        {
            if (ModelState.IsValid && user != null && !(string.IsNullOrEmpty(user.Name)) && !(string.IsNullOrEmpty(user.email)) && !(string.IsNullOrEmpty(user.password)) && !(string.IsNullOrEmpty(user.ConfirmPassword)) && user.password==user.ConfirmPassword)
            {
                

                string query = @"insert into dbo.Users values('" + user.Name + @"','" + user.email + @"','" + user.password + @"')";

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


                return RedirectToAction("Login", "Login"); ;

            }
            else
            {
                ModelState.AddModelError("", "Данные внесенны не правильно");
                return View(user);
            }
        }
    }
}
