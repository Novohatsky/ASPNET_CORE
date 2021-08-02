using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _appEnvironment;
        public HomeController(IWebHostEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult DownloadFile()
        {
            return PhysicalFile(Path.Combine(_appEnvironment.ContentRootPath, @"App_Data\001.Introduction.pdf"), "application/pdf", "001.Introduction.pdf");
        }
    }
}