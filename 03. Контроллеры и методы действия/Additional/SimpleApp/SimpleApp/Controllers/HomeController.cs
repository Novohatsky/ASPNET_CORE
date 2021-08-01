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
        private readonly ProductReader _reader = new ProductReader();

        public IActionResult Index()
        {
            List<Product> products = _reader.ReadData();
            ViewData["Title"] = "Передача данных в представление двумя способами";

            ViewBag.Products = products;

            return View(products);
        }
    }
}
