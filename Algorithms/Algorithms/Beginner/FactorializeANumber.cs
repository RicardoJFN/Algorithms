using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public static class FactorializeANumber
    {
        public static long Factorialize (long num)
        {
            #region Simple Working solution
            //long result = 1;

            //for (int i = 1; i != num + 1; i++)
            //    result *= i;
            #endregion

            #region Recursive Solution
            if (num == 0)
                return 1;
            else
                return num * Factorialize(num - 1);
            #endregion

            //return result;
        }
    }
}
