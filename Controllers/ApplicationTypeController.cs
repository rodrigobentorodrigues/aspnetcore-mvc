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
        public IActionResult Create(ApplicationType applicationType)
        {
            appTypeDAO.Insert(applicationType);
            return RedirectToAction("Index");
        }

    }
}
