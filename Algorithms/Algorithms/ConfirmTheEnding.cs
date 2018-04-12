using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public class ConfirmTheEnding
    {
        public static bool ConfirmEnding(string str, string target)
        {
            string[] arr = str.Split();
            string x = arr[arr.Length - 1];

            if (target.Length == 1 && x[x.Length - 1] == target[0] || target.Length > 1 && arr[arr.Length - 1] == target)
                return true;
            else
            {
                if ((target.Length - x.Length) < 0)
                    return false;

                string y = x.Substring((target.Length - x.Length));

                if (y.Equals(target))
                    return true;
            }

            return false;
        }
    }
}
