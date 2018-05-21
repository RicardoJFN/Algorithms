using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Intermediate
{
    public class Diff2Arrays <T>
    {
        public static T[] Diff(T[] arr1, T[]arr2)
        {
            List<T> list = new List<T>();
            T[] singleArr = new T[arr1.Length + arr2.Length];

            for (int i = 0; i != arr1.Length; i++)
                singleArr[i] = arr1[i];

            int x = 0;
            int sizeArr1 = arr1.Length;
            while (x != arr2.Length)
            {
                if (singleArr[sizeArr1] == null)
                    singleArr[sizeArr1] = arr2[x];

                sizeArr1++;
                x++;
            }

            Array.Sort(singleArr);

            //continue with searching the array for the differente word(s)
         




            //int max = Math.Max(arr1.Length, arr2.Length);

            //for (int i = 0; i != max; i++)
            //{
            //    if (i <= arr1.Length -1 && i <= arr2.Length -1)
            //        if (!arr1[i].Equals(arr2[i]))
            //            list.Add(arr1[i]);
            //}
            //Array.Sort(arr1);
            //Array.Sort(arr2);

                                




            return list.ToArray();
        }
    }
}
