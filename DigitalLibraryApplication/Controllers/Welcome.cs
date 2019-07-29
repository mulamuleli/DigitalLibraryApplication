 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DigitalLibraryApplication.Controllers
{
    public class Welcome : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewData["Message"] = "welcome to my digital library application";

            return View();
        }

         public string Description()
        {
            return "this is my first ASP.NET Core applicatoin";
        }
    }
}
