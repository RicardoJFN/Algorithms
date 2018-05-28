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
            //T[] singleArr = new T[arr1.Length + arr2.Length];

            //for (int i = 0; i != arr1.Length; i++)
            //    singleArr[i] = arr1[i];

            //int x = 0;
            //int sizeArr1 = arr1.Length;
            //while (x != arr2.Length)
            //{
            //    if (singleArr[sizeArr1] == null)
            //        singleArr[sizeArr1] = arr2[x];

            //    sizeArr1++;
            //    x++;
            //}
            //split into minor arrays and check the values
            //Array.Sort(singleArr);
            T[] arr = arr1.Concat(arr2).ToArray();
            List<T> list = new List<T>();
            Array.Sort(arr);

            for (int i = 0; i != arr.Length; i++)
            {
                if (i != arr.Length - 1)
                {
                    T firstVal = arr[i];
                    //if (i == )
                    for (int j = i + 1; j != arr.Length; j++)
                    {
                        T secondVal = arr[j];

                        if (j > arr.Length - 1)
                            if (!firstVal.Equals(secondVal))
                                list.Add(firstVal);

                        if (!firstVal.Equals(secondVal))
                        {
                            list.Add(firstVal);
                            i--;
                        }

                        break;
                    }
                    i++;
                }
                else
                {
                    list.Add(arr[i]);
                }
                
            }




            return list.ToArray();
        }
    }
}
