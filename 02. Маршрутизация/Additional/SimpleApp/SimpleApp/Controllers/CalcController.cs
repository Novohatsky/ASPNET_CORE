using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewData["Route"] = $"{RouteData.Values["Controller"]}/{RouteData.Values["Action"]}/{RouteData.Values["data"]}";

            var param = RouteData.Values["data"].ToString().Split('/');

            ViewData["CalcResult"] = Convert.ToInt32(param[0]) + Convert.ToInt32(param[1]);
            return View("Result");
        }

        public IActionResult Mul()
        {
            ViewData["Route"] = $"{RouteData.Values["Controller"]}/{RouteData.Values["Action"]}/{RouteData.Values["data"]}";

            var param = RouteData.Values["data"].ToString().Split('/');

            ViewData["CalcResult"] = Convert.ToInt32(param[0]) * Convert.ToInt32(param[1]);
            return View("Result");
        }

        public IActionResult Div()
        {
            ViewData["Route"] = $"{RouteData.Values["Controller"]}/{RouteData.Values["Action"]}/{RouteData.Values["data"]}";

            var param = RouteData.Values["data"].ToString().Split('/');

            ViewData["CalcResult"] = Convert.ToInt32(param[0]) / Convert.ToInt32(param[1]);
            return View("Result");
        }

        public IActionResult Sub()
        {
            ViewData["Route"] = $"{RouteData.Values["Controller"]}/{RouteData.Values["Action"]}/{RouteData.Values["data"]}";

            var param = RouteData.Values["data"].ToString().Split('/');

            ViewData["CalcResult"] = Convert.ToInt32(param[0]) - Convert.ToInt32(param[1]);
            return View("Result");
        }
    }
}
