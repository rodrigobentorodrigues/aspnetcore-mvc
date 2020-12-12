using CourseMVC.Interfaces;
using CourseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseMVC.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ICategoryRepo categoryDAO;

        public CategoryController(ICategoryRepo categoryRepo)
        {
            this.categoryDAO = categoryRepo;
        }

        public IActionResult Index()
        {
            var categories = categoryDAO.ListAll();
            return View(categories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            categoryDAO.Insert(category);
            return RedirectToAction("Index");
        }

    }
}
