using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public class TruncateAString
    {
        public static string Truncate (string str, int num)
        {
            if (str.Length > num && num > 3)
              return str.Substring(0, num - 3) + "...";
            else if (str.Length > num && num <= 3)
              return str.Substring(0, num) + "...";



            return str;
        }
    }
}
