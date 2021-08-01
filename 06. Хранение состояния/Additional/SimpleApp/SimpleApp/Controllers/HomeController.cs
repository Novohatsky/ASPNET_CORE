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
        private const string cookieKey = "mydata";

        public IActionResult Index()
        {
            ViewData["expired"] = DateTime.Now;
            return View();
        }

        [HttpPost]
        public IActionResult Index(string value, DateTime expired)
        {
            ViewData["value"] = value;
            ViewData["expired"] = expired;
            CookieOptions options = new CookieOptions();
            options.Expires = expired;

            if (value != null)
                Response.Cookies.Append(cookieKey, value, options);

            return View();
        }

        public IActionResult Test()
        {
            string value = Request.Cookies[cookieKey];

            if (value == null)
                value = "cookie not found!";

            return View(value as object);
        }
    }
}
