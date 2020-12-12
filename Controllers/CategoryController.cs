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
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryDAO.Insert(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            Category category = categoryDAO.GetById(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                categoryDAO.Update(category);
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            Category category = categoryDAO.GetById(id);
            if (category == null)
                return NotFound();

            return View(category);
        }

        [HttpPost]
        public IActionResult DeletePost(int? id)
        {
            Category category = categoryDAO.GetById(id);
            if (category == null)
                return NotFound();
            
            categoryDAO.Delete(category);
            return RedirectToAction("Index");
        }

    }
}
