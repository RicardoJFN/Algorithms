using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public class RepeatAString
    {
        public static string RepeatStringNumTimes(string str, int num)

        {
            string result = "";

            if (num == 1)
                return str;
            else if (num < 0)
                return "";
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    result += str;
                }

                return result;
            }
                



           
        }
    }
}
