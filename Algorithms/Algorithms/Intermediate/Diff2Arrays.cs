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

            //int max = Math.Max(arr1.Length, arr2.Length);

            //for (int i = 0; i != max; i++)
            //{
            //    if (i <= arr1.Length -1 && i <= arr2.Length -1)
            //        if (!arr1[i].Equals(arr2[i]))
            //            list.Add(arr1[i]);
            //}
            Array.Sort(arr1);
            Array.Sort(arr2);

            if (arr1.Length >= arr2.Length)
            {
                for (int i = 0; i != arr1.Length; i++)
                    for (int j = 0; j != arr2.Length; j++)
                        if (i <= arr2.Length - 1)
                        {
                            if (arr1[i].Equals(arr2[j]))
                                continue;
                            if (!arr1[i].Equals(arr2[j]))
                                list.Add(arr1[i]);
                        }
                            
            }
            else
            {
                for (int i = 0; i != arr2.Length; i++)
                    for (int j = 0; j != arr1.Length; j++)
                        if (i <= arr1.Length - 1)
                            if (!arr2[i].Equals(arr1[j]))
                                list.Add(arr2[i]);
            }
                                




            return list.ToArray();
        }
    }
}
