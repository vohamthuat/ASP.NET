using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDemo.Models;

namespace WebDemo.Controllers
{
    public class DotNetController : Controller
    {

        public IActionResult Index()
        {
            return View("MainView");
        }

        public ActionResult Act(string button)
        {
            return View("MainView");
        }

        public ActionResult LoadStudent()
        {
            Student s1 = new Student()
            {
                ID = 1001,
                FullName = "Alpha",
                DoB = new DateTime(2000, 1, 1)
            };

            return View("MainView", s1);
        }
    }
}
