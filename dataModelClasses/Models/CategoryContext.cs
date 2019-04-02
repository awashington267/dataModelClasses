using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dataModelClasses.Models
{
    public class CategoryContext : IContext
    {
        private List<Category> _categories;

        public CategoryContext()
        {
            _categories = new List<Category>
            {
                new Category { Id = 1, Name = "Toys"},
                new Category { Id = 2, Name = "Electronics"},
                new Category { Id = 3, Name = "Music"}
            };
        }

        public List<Category> GetData()
        {
            return _categories;
        }
        public Category Find(int id)
        {
            return _categories.FirstOrDefault(c => c.Id == id);
        }
    }
}