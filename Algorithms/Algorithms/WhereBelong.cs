using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class WhereBelong
    {
        public static int GetIndexToIns(int[] arr, int num)
        {
            Array.Sort(arr);
            for (int i = 0; i != arr.Length; i++)
            {
                if (num > arr[arr.Length - 1])
                    return arr.Length;
                if (num > arr[i] && num <= arr[i + 1])
                    return i + 1; 
            }

            return 0;
        }
    }
}
