using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Algorithms
{
    public class CaesarsCipher
    {
        public static string Rot13(string str)
        {
            char[] firstHalf = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M' };
            char[] secondHalf = new char[] { 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

            Regex rg = new Regex(@"^[a-zA-Z0-9\s,]*$");

            string final = "";


            for (int i = 0; i != str.Length; i++)
            {
                if (str[i] == '?' || str[i] == ' ' || str[i] == '.' || str[i] == '!')
                    final += str[i];

                for (int j = 0; j != secondHalf.Length; j++)
                {


                    if (str[i].Equals(secondHalf[j]))
                        final += firstHalf[j];

                    if (str[i].Equals(firstHalf[j]))
                        final += secondHalf[j];

                }
            }
                









            return final;
        }
    }
}
