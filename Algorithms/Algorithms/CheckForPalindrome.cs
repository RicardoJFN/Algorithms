using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public static class CheckForPalindrome
    {
        public static bool Palindrome(string str)
        {
            string inverse = "";

            for (int i = str.Length; i != 0; i--)
            {
                char x = str[i - 1];

                inverse += x;
            }

            Regex rx = new Regex(@"[^a-zA-Z0-9]+");
            inverse = rx.Replace(inverse, "").ToLower();
            str = rx.Replace(str, "").ToLower();

            if (inverse.Equals(str))
                return true;
            else
                return false;
            
        }
    }
}
