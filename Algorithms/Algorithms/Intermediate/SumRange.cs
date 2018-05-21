using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Intermediate
{
    public class SumRange
    {
        public static int SumAll(int[] arr)
        {

           
            int min, max, result = 0;

            max = Math.Max(arr[0], arr[1]);
            min = Math.Min(arr[0], arr[1]);
            
            for (int i = min; i <= max; i++)
            {
                result = result + i;
            }


            return result;
        }
    }
}
