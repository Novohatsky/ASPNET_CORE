using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleApp.Services
{
    public class CalcService
    {
        public decimal? Add(string arg1, string arg2)
        {
            return ConvertToDouble(arg1) + ConvertToDouble(arg2);
        }

        public decimal? Sub(string arg1, string arg2)
        {
            return ConvertToDouble(arg1) - ConvertToDouble(arg2);
        }

        public decimal? Mul(string arg1, string arg2)
        {
            return ConvertToDouble(arg1) * ConvertToDouble(arg2);
        }

        public decimal? Div(string arg1, string arg2)
        {
            return ConvertToDouble(arg2) != 0 ? ConvertToDouble(arg1) / ConvertToDouble(arg2) : null;
        }

        private decimal? ConvertToDouble(string value)
        {
            try
            {
                return !string.IsNullOrEmpty(value) ? Convert.ToDecimal(value.Replace(',', '.'), new NumberFormatInfo { NumberDecimalSeparator = "." }) : (decimal?)null;
            }
            catch { return null; }
        }
    }
}
