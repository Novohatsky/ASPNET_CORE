using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp2.Controllers
{
    public class PageController : Controller
    {
        public IActionResult Page1()
        {
            return View();
        }

        public IActionResult Page2()
        {
            return View();
        }

        public IActionResult Menu1()
        {
            return View();
        }

        public IActionResult Menu2()
        {
            return View();
        }

        public IActionResult Menu3()
        {
            return View();
        }
    }
}
