using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Diagnostics;

namespace SimpleApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegistrationBindingModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.ConsultDate <= System.DateTime.Now || model.ConsultDate.DayOfWeek == System.DayOfWeek.Sunday || model.ConsultDate.DayOfWeek == System.DayOfWeek.Saturday)
                {
                    ModelState.AddModelError(nameof(model.ConsultDate), "Дата консультации должна быть в будущем и не должна попадать на выходные дни");
                    return View(model);
                }

                Debug.WriteLine($"В базу записан пользователь: {model.FirstName} {model.LastName} (email: {model.Email}, ConsultDate: {model.ConsultDate})");
                return View("Success");
            }
            else
            {
                // если модель содержит значения противоречащие бизнес правилам - возвращаем то же самое представление с неправильными данными
                // для того, чтобы пользователь мог их поправить
                return View(model);
            }
        }
    }
}

