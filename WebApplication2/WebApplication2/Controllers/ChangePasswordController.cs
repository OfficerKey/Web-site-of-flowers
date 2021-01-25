using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    [Route("change")]
    [ApiController]
    public class ChangePasswordController:Controller
    {
        private readonly IConfiguration _configuration;

        public ChangePasswordController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        [HttpGet]
        public IActionResult Change()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Change([FromForm] User user)
        {
            if (ModelState.IsValid && user != null && !(string.IsNullOrEmpty(user.email)) && !(string.IsNullOrEmpty(user.password)) && !(string.IsNullOrEmpty(user.ConfirmPassword)))
            {
                if(user.password == user.ConfirmPassword)

                {
                    string query = @"update dbo.Users set password='"+user.password+@"' where email='"+user.email+@"'";

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



                    return RedirectToAction("Login", "Login");
                }
                else
                {
                    return View(user);

                }
                
                
            }
            else
            {
                return View("Bed");
            }
        }
    }
}
