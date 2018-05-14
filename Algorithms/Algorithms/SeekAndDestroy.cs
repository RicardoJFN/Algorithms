using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SeekAndDestroy
    {
        public static int[] Destroyer (int[] arr, int first, int second)
        {
            List<int> list = new List<int>();
            for (int i = 0; i != arr.Length; i++)
                if (arr[i] != first && arr[i] != second)
                    list.Add(arr[i]);

            return list.ToArray();
        }

        public static int[] Destroyer(int[] arr, int first, int second, int third)
        {
            List<int> list = new List<int>();
            for (int i = 0; i != arr.Length; i++)
                if (arr[i] != first && arr[i] != second && arr[i] != third)
                    list.Add(arr[i]);

            return list.ToArray();
        }

        public static string[] Destroyer(string[] arr, string first, string second)
        {
            List<string> list = new List<string>();
            for (int i = 0; i != arr.Length; i++)
                if (arr[i] != first && arr[i] != second)
                    list.Add(arr[i]);

            return list.ToArray();
        }
    }
}
