using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using System.IO;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ly_Audrey_HW1.Controllers
{


    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _environment;
        public HomeController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AboutMe()
        {
            return View();
        }

        public IActionResult Blog()
        {
            return View();
        }

        public IActionResult Resume()
        {
            string path = _environment.WebRootPath + "/files/Audrey_Ly_Resume_Microsoft.pdf";
            var stream = new FileStream(path, FileMode.Open);
            return File(stream, "application/pdf", "Audrey_Ly_Resume_Microsoft.pdf");
        }

        public IActionResult Portfolio()
        {
            return View();
        }
    }
}

