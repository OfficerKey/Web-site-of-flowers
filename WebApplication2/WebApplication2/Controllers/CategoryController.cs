using Microsoft.AspNetCore.Mvc;

using Microsoft.Extensions.Configuration;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    
    [ApiController]
    public class CategoryController: Controller
    {
        List<Category> categoryList = new List<Category>();
        private readonly IConfiguration _configuration;
        List<Products> productsList = new List<Products>();

        public CategoryController(IConfiguration configuration)
        {
            this._configuration = configuration;
        }


        



        [HttpGet("category")]
        public IActionResult GetCategory([FromQuery] string search)
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




            //Product


            string query2 = null;

            if((string.IsNullOrEmpty(search)))
            {
                query2 += @"select CategoryId,Name,price,description from dbo.Product";
            }
            else if(!(string.IsNullOrEmpty(search)))
            {
                query2 += @"select CategoryId,Name,price,description from dbo.Product where Name like '%" + search + "%'";
            }
           



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
                productsList.Add(new Products() { Name = (string)item["Name"], price = (int)item["price"], description = (string)item["description"] });

            }


            List<CategoryModel> categoryModels = categoryList.Select(c => new CategoryModel { id = c.Id, name = c.Name }).ToList();

            categoryModels.Insert(0, new CategoryModel { id = 0, name = "Все" });

            CategoryProductModel categoryProductModel = new CategoryProductModel { categories = categoryModels, productsmodel = productsList };
           




            return View(categoryProductModel);
           
        }
        [HttpPost("category")]
        public IActionResult GetCategory([FromForm]int? categoryId)
        {

            //Category




            string query = @"select id,Name from dbo.Category "; 

            
            
            
            

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
                categoryList.Add(new Category { Id= (int)item["id"],Name = (string)item["Name"] });
            }




            //Product
            string query2 = null;


            switch (categoryId)
            {
                case 0:
                    query2 = @"select id, Name,price,description from dbo.Product ";
                    break;
                default:
                    query2 = @"select id, Name,price,description from dbo.Product where CategoryId=" + categoryId + @" ";
                    break;


            }
             
            
            

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
                productsList.Add(new Products() { id= (int)item["id"], Name = (string)item["Name"], price = (int)item["price"], description = (string)item["description"] });

                

            }


            var client = new MongoClient("mongodb://localhost:27017/?readPreference=primary&appname=MongoDB%20Compass%20Community&ssl=false");
            var database = client.GetDatabase("cmscart");
            var collection = database.GetCollection<Images>("images");

            //var result = collection.Find(new BsonDocument()).ToList();
            //foreach (Images item2 in result)
            //{
            //    productsList.Add(new Products() { image = item2["image"] });
            //}






            List<CategoryModel> categoryModels = categoryList.Select(c => new CategoryModel { id = c.Id, name = c.Name }).ToList();

            categoryModels.Insert(0, new CategoryModel { id = 0, name = "Все" });

            CategoryProductModel categoryProductModel = new CategoryProductModel { categories = categoryModels, productsmodel = productsList };
           
                
            


            return View(categoryProductModel);

        }
        
        
    }
}
