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

        public Category GetById(int? id)
        {
            return dbContext.Categories.Find(id);
        }

        public void Insert(Category category)
        {
            dbContext.Categories.Add(category);
            dbContext.SaveChanges();
        }

        public IEnumerable<Category> ListAll()
        {
            return dbContext.Categories;
        }

        public void Update(Category category)
        {
            dbContext.Categories.Update(category);
            dbContext.SaveChanges();
        }
    }
}
