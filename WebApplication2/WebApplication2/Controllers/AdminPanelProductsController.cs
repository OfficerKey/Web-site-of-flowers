using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Interfaces;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AdminPanelProductsController : Controller,IAdminPanel
    {
        List<Category> categoryList = new List<Category>();
        List<Products> productsList = new List<Products>();
        private readonly IConfiguration _configuration;

        public AdminPanelProductsController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }
        
        [HttpGet("admin/product")]
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "")
            {
                string query2 = @"select id,CategoryId,Name,price,description from dbo.Product";



                DataTable table2 = new DataTable();
                string sqlDataSource2 = _configuration.GetConnectionString("CommandsConnection");
                SqlDataReader myReader2;

                using (SqlConnection myCon2 = new SqlConnection(sqlDataSource2))
                {
                    myCon2.Open();
                    using (SqlCommand myCommand2 = new SqlCommand(query2, myCon2))
                    {
                        myReader2 = myCommand2.ExecuteReader();
                        table2.Load(myReader2);

                        myReader2.Close();
                        myCon2.Close();
                    }
                }
                foreach (DataRow item in table2.Rows)
                {
                    productsList.Add(new Products() { id = (int)item["id"], Name = (string)item["Name"], price = (int)item["price"], description = (string)item["description"] });

                }
                CategoryProductModel categoryProductModel = new CategoryProductModel { productsmodel = productsList };
                return View(categoryProductModel);

            }
            else
            {
                return Redirect("/home");
            }
            
        }

       
        
        [HttpGet("admin/add")]
        public IActionResult Insert()
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

            }
            else
            {
                return Redirect("/home");
            }
            







            List<CategoryModel> categoryModels = categoryList.Select(c => new CategoryModel { id = c.Id, name = c.Name }).ToList();
            CategoryProductModel categoryProductModel = new CategoryProductModel
            {
                categories = categoryModels
            };

            return View(categoryProductModel);
        }


        [HttpPost("admin/add")]
        public IActionResult Insert([FromForm] Products product, IFormFile file )
        {
            Images image = new Images();
            if (ModelState.IsValid && product != null && !(string.IsNullOrEmpty(product.Name)) && product.price != 0 && !(string.IsNullOrEmpty(product.description)) && product.CategoryId != 0)
            {



                //insert
                string query = @"insert into dbo.Product values('" + product.Name + @"'," + product.price + @",'" + product.description + @"'," + product.CategoryId + @")";

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



                if(product.image !=null)
                {
                    //select
                    string query2 = @"select id from dbo.Product where Name= '" + product.Name + @"'";

                    DataTable table2 = new DataTable();
                    string sqlDataSource2 = _configuration.GetConnectionString("CommandsConnection");
                    SqlDataReader myReader2;

                    using (SqlConnection myCon = new SqlConnection(sqlDataSource2))
                    {
                        myCon.Open();
                        using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                        {
                            myReader2 = myCommand.ExecuteReader();
                            table2.Load(myReader2);

                            myReader2.Close();
                            myCon.Close();
                        }
                    }

                    foreach (DataRow item in table2.Rows)
                    {
                        image.id = (int)item["id"];
                    }

                    byte[] resultBytes;
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        image.image = ms.ToArray();
                    }

                    var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false");
                    var database = client.GetDatabase("cmscart");
                    var collection = database.GetCollection<Images>("images");



                    collection.InsertOne(image);


                    return Redirect("/admin/product");
                }
                else
                {
                    return Redirect("/admin/product");
                }

                

            }
            else
            {
                return Content("Bed");
            }
        }
        [HttpGet("admin/update/{id?}")]
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


       [HttpPost("admin/update/{id?}")]
        public IActionResult Update([FromForm] Products product, IFormFile file)
        {
            Images image = new Images();
            if (ModelState.IsValid && product != null && !(string.IsNullOrEmpty(product.Name)) && product.price != 0 && !(string.IsNullOrEmpty(product.description)) && product.CategoryId != 0 && product.id!=0)
            {



                //update
                string query = @"update dbo.Product set Name='" + product.Name + @"',price=" + product.price + @",description='" + product.description + @"',CategoryId=" + product.CategoryId + @" Where id="+product.id+@"";

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


                //select
                string query2 = @"select id from dbo.Product where Name= '" + product.Name + @"'";

                DataTable table2 = new DataTable();
                string sqlDataSource2 = _configuration.GetConnectionString("CommandsConnection");
                SqlDataReader myReader2;

                using (SqlConnection myCon = new SqlConnection(sqlDataSource2))
                {
                    myCon.Open();
                    using (SqlCommand myCommand = new SqlCommand(query2, myCon))
                    {
                        myReader2 = myCommand.ExecuteReader();
                        table2.Load(myReader2);

                        myReader2.Close();
                        myCon.Close();
                    }
                }






                if (product.image != null)
                {
                    foreach (DataRow item in table2.Rows)
                    {
                        image.id = (int)item["id"];
                    }

                    byte[] resultBytes;
                    using (var ms = new MemoryStream())
                    {
                        file.CopyTo(ms);
                        image.image = ms.ToArray();
                    }

                    var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false");
                    var database = client.GetDatabase("cmscart");
                    var collection = database.GetCollection<Images>("images");



                    collection.InsertOne(image);


                    return Redirect("/admin/product");
                }
                else
                {
                    return Redirect("/admin/product");
                }



            }
            else
            {
                return Content("Bed");
            }
        }
        //[HttpDelete("admin/product/{id}")]
        public IActionResult Delete(int id)
        {
            if (User.Identity.IsAuthenticated && User.Identity.Name == "kalishvlad3@gmail.com")
            {
                string query = @"Delete from dbo.Product where id=" + id + "";
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

                return Redirect("/admin/product");

            }
            else
            {
                return Redirect("/home");
            }
           
        }
        

        
    }
}
