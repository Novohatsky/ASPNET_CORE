using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Models
{
    public class MyModel
    {
        public string First { get; set; }

        public string Second { get; set; }

        public int Count { get; set; }

        public override string ToString()
        {
            return $"First: {First}, Second:{Second}, Count:{Count}";
        }
    }
}
