using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["IpAddress"] = HttpContext.Connection. RemoteIpAddress; 
            ViewData["Client"] = HttpContext.Request.Headers["User-Agent"];
            return View();
        }
    }
}
