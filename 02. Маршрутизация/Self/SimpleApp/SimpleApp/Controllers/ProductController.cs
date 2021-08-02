using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductReader _reader;

        // ВНИМАНИЕ.
        // Каждый запрос обрабатывает новый экземпляр контроллера.
        // Конструктор будет вызываться перед вызовом метода List и метода Details
        // После обработки запроса, экземпляр контроллера будет удален из памяти
        public ProductController()
        {
            _reader = new ProductReader();
        }

        // Product/List
        public IActionResult List(string category)
        {
            List<Product> products = !string.IsNullOrEmpty(category) ? _reader.ReadFromFile().Where(p => p.Category == category).ToList() : _reader.ReadFromFile();
            // Возврат представления List и передача представлению модели в виде коллекции products
            // Получить доступ к коллекции в представлении можно будет через свойство представления Model
            return View(products);
        }

        // Product/Detail/1
        public IActionResult Detail(int id)
        {
            List<Product> products = _reader.ReadFromFile();
            Product product = products.Where(x => x.Id == id).FirstOrDefault();

            if (product != null)
            {
                // Возврат представления с именем Details и передача представлению экземпляра product
                // В представление доступ к экземпляру можно получить через свойство представления Model
                return View(product);
            }
            else
            {
                // Возврат ошибки 404
                return NotFound();
            }
        }
    }
}