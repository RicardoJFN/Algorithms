using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.fCC
{
    public class ChunkyMonkey
    {
        public static string[,] ChunkArrayInGroups(string[] arr, int size)
        {
            string[,] x = new string[,] { };
            string y = x[0, 0];
            for (int i = 0; i != arr.Length; i++)
            {
                if (i + 1 == size)
                    x[i, i] = arr[i];
                //x[i, i] = arr[i];
                x[0, 0] = arr[i];
            }
            return x;
        }

        public static int[,] ChunkArrayInGroups(int[] arr, int size)
        {
            int[,] x = new int[,] { };

            return x;
        }
    }
}
