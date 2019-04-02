using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dataModelClasses.Models
{  
    public class ProductContext : IContext
    {
        private List<Product> _products;
        public ProductContext()
        {
            _products = new List<Product>()
            {
                new Product {Id=100, Name = "Shakira CD", Price = 10.00m, CatID = 3},
                new Product {Id=101, Name = "Computer", Price = 600.00m, CatID = 2},
                new Product {Id=102, Name = "Printer", Price = 200.00m, CatID = 2},
                new Product {Id = 103, Name = "Toy Car", Price = 15.00m, CatID = 1}
            };
        }

        public List<Product> GetData()
        {
            return _products;
        }
        public Product Find(int id)
        {
           return _products.FirstOrDefault(p => p.Id == id);
        }
    }
    
}