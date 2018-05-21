using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public static class TitleCaseASentence
    {
        public static string TitleCase(string str)
        {
            string[] splitString = str.ToLower().Split();
            string newString = "";


            
            for (int i = 0; i != splitString.Length; i++)
            {

                for (int j = 0; j != splitString[i].Length; j++)
                {
                    if (j == 0)
                    {
                        string x = splitString[i][j].ToString().ToUpper();
                        newString += x;
                    }
                    else
                    {
                        newString += splitString[i][j];
                    }

                    if (j >= splitString[i].Length - 1)
                        newString += " ";

                }
            }
            

            

            return newString;
        }
    }
}
