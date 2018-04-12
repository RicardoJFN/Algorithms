using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public class LargestNumberArrays
    {
        public static int[] LargestOfFour(int[,] arr)
        {
            int[] newArr = new int[arr.GetLength(0)];
            

            for (int i = 0; i != arr.GetLength(0); i++)
            {
                int num = 0;
                for (int j = 0; j != arr.GetLength(1); j++)
                {
                    
                    if (arr[i, j] > num && arr[i, j] + 1 >= num)
                    {
                        num = arr[i, j];
                        newArr[i] = num;
                    }

                    
                }
            }

            return newArr;
        }
    }
}
