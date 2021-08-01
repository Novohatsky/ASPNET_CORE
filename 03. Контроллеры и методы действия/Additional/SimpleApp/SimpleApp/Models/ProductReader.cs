using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class ProductReader
    {
        public List<Product> ReadData()
        {
            return new List<Product>() 
            {
                new Product() { Id = 1, Name = "Транклюкатор", Price = 12.45},
                new Product() { Id = 2, Name = "Флюктуатор", Price = 32.6},
                new Product() { Id = 3, Name = "Глюканатор", Price = 112.77},
            };
        }
    }
}
