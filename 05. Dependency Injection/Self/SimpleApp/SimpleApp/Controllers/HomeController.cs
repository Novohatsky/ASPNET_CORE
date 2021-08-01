using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApp.Models;
using SimpleApp.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        private IServiceResult _service;

        public HomeController(IServiceResult service)
        {
            _service = service;
        }

        public IActionResult Index()
        {
            ViewData["serviceResult"] = _service.GetList().ToList();

            return View();
        }
    }
}
