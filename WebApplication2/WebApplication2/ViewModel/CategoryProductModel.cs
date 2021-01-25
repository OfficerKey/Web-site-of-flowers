using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class CategoryProductModel
    {
        public IEnumerable<CategoryModel> categories { get; set; }
        public IEnumerable<Products> productsmodel { get; set; }
    }
}
