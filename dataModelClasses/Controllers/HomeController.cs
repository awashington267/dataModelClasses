using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using dataModelClasses.Models;

namespace dataModelClasses.Controllers
{
    public class HomeController : Controller
    {

         List<Product> products = new List<Product>()
        {//m is used to convert to decimal
            new Product {Id=100, Name = "Shakira CD", Price = 10.00m, CatID = 3},
            new Product {Id=101, Name = "Computer", Price = 600.00m, CatID = 2},
            new Product {Id=102, Name = "Printer", Price = 200.00m, CatID = 2},
            new Product {Id=103, Name = "Race Car", Price = 30.00m, CatID = 1}
        };
         List<Category> categories = new List<Category>()
        {
            new Category { Id = 1, Name = "Toy"},
            new Category { Id = 2, Name = "Electronics"},
            new Category { Id = 3, Name = "Music"}
        };

        public ActionResult Products(int? id)
        {

            var p = new ProductContext();
            var products = p.GetData();

            if (id == null)
            {
                return View(products);
            }
            else
            {
                return View(products.Where(c => c.CatID == id));
            } 
            
        }

        

        public ActionResult Categories()
        {
            /*var c = new ProductContext();
            var category = c.GetData();*/
            return View(categories);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        /*public ActionResult Category()
        {
            using (var db = new NorthwindEntities())
        }*/
    }
}