using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Services
{
    public interface IServiceResult
    {
        IEnumerable<string> GetList();
    }
}
