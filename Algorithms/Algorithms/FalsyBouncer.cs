using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class FalsyBouncer
    {
        public static Object[] Bouncer (Object[] arr)
        {
            Object[] falsyValues = new Object[] { false, 0, "undefined", "NaN", "" };

            int n = 0;

            for (int i = 0; i != falsyValues.Length; i++)
            {
                for (int j = 0; j != arr.Length; j++)
                {
                    if (falsyValues[i] != arr[j] || !falsyValues[i].Equals(arr[j]) || arr[j] != null)
                    {
                        n++;
                        break;
                    }
                        
                }
            }





            //for (int i = 0; i != falsyValues.Length; i++)
            //{
            //    for (int j = 0; j != arr.Length; j++)
            //    {
            //        if (falsyValues[i] == arr[j] || falsyValues[i].Equals(arr[j]) || arr[j] == null)
            //            n++;
            //    }
            //}

            //Object[] tempFalsy = new Object[n];

            //for (int i = 0; i != tempFalsy.Length; i++)
            //    for (int j = 0; j != falsyValues.Length; j++)
            //        for (int l = 0; l != arr.Length; l++)
            //            if (falsyValues[j] == arr[l] || falsyValues[j].Equals(arr[l]) || arr[l] == null)
            //            {
            //                tempFalsy[i] = arr[l];
            //                break;
            //            }





            //int length = 0;

            //for (int i = 0; i != arr.Length; i++)
            //    for (int j = 0; j != falsyValues.Length; j++)
            //        if (arr[i] == falsyValues[j] || arr[i].Equals(falsyValues[j]))
            //            length++;

            //Object[] remain = new Object[arr.Length - length];

            //for (int i = 0; i != remain.Length; i++)
            //    for (int j = 0; j != falsyValues.Length; j++)
            //        for (int z = 0; z != arr.Length; z++)
            //            if ()



            //for (int i = 0; i != arr.Length; i++)
            //    for (int j = 0; j != falsyValues.Length; j++)
            //        if (arr[j] != falsyValues[z] || !arr[j].Equals(falsyValues[z]))
            //            remain[] = arr[i];




            string safe = "stop";

            return arr;
        }
    }
}
