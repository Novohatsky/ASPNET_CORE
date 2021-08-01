using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Services
{
    public class DaysOfWeek : IServiceResult
    {
        public IEnumerable<string> GetList()
        {
            return DateTimeFormatInfo.CurrentInfo.DayNames;
        }
    }
}
