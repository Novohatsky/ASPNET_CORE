using Microsoft.AspNetCore.Mvc;
using SimpleApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        CalcService _CalcService;

        public HomeController(CalcService calcService)
        {
            _CalcService = calcService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add(string arg1, string arg2)
        {
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            var calcResult = _CalcService.Add(arg1, arg2);
            ViewData["CalcResult"] = calcResult.HasValue ? $"{arg1} + {arg2} = {calcResult}" : "Аргуметы заданы неверно!";

            return View("Index");
        }

        public IActionResult Sub(string arg1, string arg2)
        {
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            var calcResult = _CalcService.Sub(arg1, arg2);
            ViewData["CalcResult"] = calcResult.HasValue ? $"{arg1} - {arg2} = {calcResult}" : "Аргуметы заданы неверно!";

            return View("Index");
        }

        public IActionResult Mul(string arg1, string arg2)
        {
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            var calcResult = _CalcService.Mul(arg1, arg2);
            ViewData["CalcResult"] = calcResult.HasValue ? $"{arg1} * {arg2} = {calcResult}" : "Аргуметы заданы неверно!";

            return View("Index");
        }

        public IActionResult Div(string arg1, string arg2)
        {
            ViewData["arg1"] = arg1;
            ViewData["arg2"] = arg2;

            var calcResult = _CalcService.Div(arg1, arg2);
            ViewData["CalcResult"] = calcResult.HasValue ? $"{arg1} / {arg2} = {calcResult}" : "Аргуметы заданы неверно!";

            return View("Index");
        }
    }
}
