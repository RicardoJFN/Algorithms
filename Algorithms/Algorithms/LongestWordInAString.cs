using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public static class LongestWordInAString
    {
        public static int Longest(string str)
        {
            string[] x = str.Split();
            int max = 0;

            foreach(string item in x)
            {
                if (item.Length > max)
                    max = item.Length;
            }

            return max;
        }
    }
}
