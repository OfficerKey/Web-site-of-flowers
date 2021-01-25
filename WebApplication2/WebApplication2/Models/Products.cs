using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using static System.Net.Mime.MediaTypeNames;

namespace WebApplication2.Models
{
    public class Products
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int price { get; set; }
        public string description { get; set; }
        public byte[] image { get; set; }
        public Category category { get; set; }
        public int CategoryId { get; set; }
    }
}
