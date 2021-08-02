using Microsoft.AspNetCore.Http;
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
        public static List<string> sessions = new List<string>();

        public IActionResult Index()
        {
            if (!sessions.Contains(HttpContext.Session.Id))
                sessions.Add(HttpContext.Session.Id);

            return View();
        }
    }
}
