using Microsoft.AspNetCore.Mvc;
using Student_Management_System.Models;
using System.Diagnostics;

namespace Student_Management_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly SMSContext context;

        public HomeController(SMSContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            var show = context.Students.ToList();
            return View(show);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student std)
        {
            context.Students.Add(std);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var show = context.Students.Find(id);
            return View(show);
        }
        [HttpPost]
        public IActionResult Edit(int id , Student std)
        {
            context.Students.Update(std);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            var show = context.Students.Find(id);
            return View(show);
        }
        public IActionResult Delete(int id)
        {
            var show = context.Students.Find(id);
            return View(show);
        }
        [HttpPost]
        public IActionResult Delete(int id , Student std)
        {
            context.Students.Remove(std);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}