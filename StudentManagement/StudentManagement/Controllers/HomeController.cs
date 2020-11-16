using Microsoft.AspNetCore.Mvc;
using StudentManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepossitory _studentRepossitory;

        public HomeController(IStudentRepossitory studentRepossitory)
        {
            _studentRepossitory = studentRepossitory;
        }
        public string Index()
        {
            return _studentRepossitory.GetStudent(1).name;
        }

        public IActionResult Details()
        {
            Student student = _studentRepossitory.GetStudent(1);
            return View(student); 
        }
    }
}
