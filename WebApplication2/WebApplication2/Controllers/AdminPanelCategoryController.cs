using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminPanelCategoryController : Controller,IAdminPanel
    {
        List<Category> categoryList = new List<Category>();
        private readonly IConfiguration _configuration;
        
        public AdminPanelCategoryController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }



        public IActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
            {
                string query = @"Delete from dbo.Category where id=" + id + "";
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

                return Redirect("/admin/category");

            }
            else
            {
                return Redirect("/home");
            }
           
        }




        [HttpGet("admin/category")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
            {
                string query = @"select id,Name from dbo.Category";

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
                foreach (DataRow item in table.Rows)
                {
                    categoryList.Add(new Category { Id = (int)item["id"], Name = (string)item["Name"] });
                }
                List<CategoryModel> categoryModels = categoryList.Select(c => new CategoryModel { id = c.Id, name = c.Name }).ToList();
                CategoryProductModel categoryProductModel = new CategoryProductModel
                {
                    categories = categoryModels
                };
                return View(categoryProductModel);

            }
            else
            {
                return Redirect("/home");
            }
            
        }


        [HttpGet("admin/addCategory")]
        public IActionResult Insert()
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
            {
                return View();

            }
            else
            {
                return Redirect("/home");
            }

        }
        
        [HttpPost("admin/addCategory")]
        public IActionResult PostInsert([FromForm] Category category)
        {
            if (ModelState.IsValid && category != null && !(string.IsNullOrEmpty(category.Name)) )
            {



                //insert
                string query = @"insert into dbo.Category values('" + category.Name + @"')";

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
                return Redirect("/admin/category");
            }

            
            else
            {
                return Redirect("/admin/category");
            }
        }


        [HttpGet("admin/updateCategory/{id?}")]
        public IActionResult Update()
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
            {
                string query = @"select id,Name from dbo.Category";

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
                foreach (DataRow item in table.Rows)
                {
                    categoryList.Add(new Category { Id = (int)item["id"], Name = (string)item["Name"] });
                }


                List<CategoryModel> categoryModels = categoryList.Select(c => new CategoryModel { id = c.Id, name = c.Name }).ToList();
                CategoryProductModel categoryProductModel = new CategoryProductModel
                {
                    categories = categoryModels
                };

                return View(categoryProductModel);

            }
            else
            {
                return Redirect("/home");
            }
           
        }

        [HttpPost("admin/updateCategory/{id?}")]
        public IActionResult PostUpdate([FromForm] Category category)
        {
            if (ModelState.IsValid && category != null && !(string.IsNullOrEmpty(category.Name)) && category.Id!=0)
            {



                //update
                string query = @"update dbo.Category set Name='" + category.Name + @"' Where id=" + category.Id + @"";

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


                
                    return Redirect("/admin/category");
                



            }
            else
            {
                return Content("Bed");
            }
        }

        
    }
}
