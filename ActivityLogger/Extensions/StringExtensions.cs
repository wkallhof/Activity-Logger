using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActivityLogger.Extensions
{
    public static class StringExtensions
    {
        public static string NewlineToBr(this string s)
        {
            return s.Replace("\n", "<br>");
        }
    }
}
