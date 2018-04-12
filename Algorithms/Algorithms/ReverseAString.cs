using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public static class ReverseAString
    {
        public static string Reverse(string str)
        {
            
            string newString = "";
            for (int i = str.Length; i != 0; i--)
            {
                char c = str[i - 1];
                newString += c;
            }

            return newString;
        }
    }
}
