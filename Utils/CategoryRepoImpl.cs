using CourseMVC.Data;
using CourseMVC.Interfaces;
using CourseMVC.Models;
using System.Collections.Generic;

namespace CourseMVC.Utils
{
    public class CategoryRepoImpl : ICategoryRepo
    {
        public readonly ApplicationDbContext dbContext;

        public CategoryRepoImpl(ApplicationDbContext context)
        {
            this.dbContext = context;
        }

        public IEnumerable<Category> ListAll()
        {
            return dbContext.Categories;
        }
    }
}
