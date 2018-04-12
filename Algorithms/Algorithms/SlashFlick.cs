using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SlashFlick
    {
        public static string[] Slasher(string[] arr, int num)
        {
            
            string[] newArr;

            if (num == 0)
                return arr;
            else if (num > arr.Length)
                return Array.Empty<string>();
            else
            {
                newArr = new string[arr.Length - num];
                for (int i = 0; i != arr.Length; i++)
                {
                    if (i >= num)
                        newArr[i - num] = arr[i];
                }
            }
            
            return newArr;
        }

        
    }
}
