using Microsoft.AspNetCore.Mvc;
using QuizSphere.Models;
using System;
namespace QuizSphere.Controllers
{
    public class AuthController : Controller
    {

        private readonly QuizSphereContext _context;

        public AuthController(QuizSphereContext context)
        {
            _context = context;
        }

        public IActionResult Register()
        {
            var departments = _context.Departments.ToList();
            ViewBag.Departments = departments;
            return View();
        }


         [HttpPost]
        public IActionResult Register(Users user)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = _context.Departments.ToList();
                return View(user);
            }

            _context.Users.Add(user);
            _context.SaveChanges();

            return RedirectToAction("Login");
        }

       
    }
}