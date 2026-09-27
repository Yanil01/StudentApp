using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Ram",
                    Course = "ASP.NET"
                },

                new Student
                {
                    Id = 2,
                    Name = "Sita",
                    Course = "C#"
                },

                new Student
                {
                    Id = 3,
                    Name = "Hari",
                    Course = "Web Development"
                }
            };

            return View(students);
        }
    }
}