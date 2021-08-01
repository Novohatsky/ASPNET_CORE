using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index([FromForm]string message)
        {
            return View();
        }

        private decimal? ConvertToDouble(string value)
        {
            try
            {
                return !string.IsNullOrEmpty(value) ? Convert.ToDecimal(value.Replace(',', '.'), new NumberFormatInfo { NumberDecimalSeparator = "." }) : (decimal?)null;
            }
            catch { return null; }
        }

        public IActionResult Add(string arg1, string arg2)
        {
            // использование параметров
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            decimal? result = ConvertToDouble(arg1) + ConvertToDouble(arg2);

            ViewData["CalcResult"] = result;

            return View("Index");
        }

        public IActionResult Sub()
        {
            // использование данных запроса
            ViewData["arg1"] = Request.Form.FirstOrDefault(p => p.Key == "arg1").Value;
            ViewData["arg2"] = Request.Form.FirstOrDefault(p => p.Key == "arg2").Value;

            decimal? v1 = ConvertToDouble(ViewData["arg1"].ToString());
            decimal? v2 = ConvertToDouble(ViewData["arg2"].ToString());
            decimal? result = v1 - v2;

            ViewData["CalcResult"] = result;

            return View("Index");
        }

        public IActionResult Mul(string arg1, string arg2)
        {
            // использование параметров
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            decimal? result = ConvertToDouble(arg1) * ConvertToDouble(arg2);

            ViewData["CalcResult"] = result;

            return View("Index");
        }

        public IActionResult Div(string arg1, string arg2)
        {
            // использование параметров
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            decimal? result = ConvertToDouble(arg2) != 0 ? ConvertToDouble(arg1) / ConvertToDouble(arg2) : null;

            ViewData["CalcResult"] = result;

            return View("Index");
        }
    }
}
