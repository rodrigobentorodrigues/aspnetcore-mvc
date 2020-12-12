using CourseMVC.Interfaces;
using CourseMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CourseMVC.Controllers
{
    public class ApplicationTypeController : Controller
    {

        private readonly IApplicationTypeRepo appTypeDAO;

        public ApplicationTypeController(IApplicationTypeRepo appTypeDAO)
        {
            this.appTypeDAO = appTypeDAO;
        }

        public IActionResult Index()
        {
            var types = appTypeDAO.ListAll();
            return View(types);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                appTypeDAO.Insert(applicationType);
                return RedirectToAction("Index");
            }

            return View(applicationType);
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            ApplicationType applicationType = appTypeDAO.GetById(id);
            if (applicationType == null)
                return NotFound();

            return View(applicationType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ApplicationType applicationType)
        {
            if (ModelState.IsValid)
            {
                appTypeDAO.Update(applicationType);
                return RedirectToAction("Index");
            }

            return View(applicationType);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
                return NotFound();

            ApplicationType applicationType = appTypeDAO.GetById(id);
            if (applicationType == null)
                return NotFound();

            return View(applicationType);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePost(int? id)
        {
            ApplicationType applicationType = appTypeDAO.GetById(id);
            if (applicationType == null)
                return NotFound();

            appTypeDAO.Delete(applicationType);
            return RedirectToAction("Index");
        }

    }
}
