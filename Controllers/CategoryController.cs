using CourseMVC.Interfaces;
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

    }
}
