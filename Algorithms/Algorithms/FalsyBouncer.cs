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
            Object[] falsyValues = new Object[] { false, null, 0, "undefined", "NaN", "" };

            int length = 0;

            for (int i = 0; i != arr.Length; i++)
                for (int j = 0; j != falsyValues.Length; j++)
                    if (arr[i] == falsyValues[j] || arr[i].Equals(falsyValues[j]))
                        length++;

            Object[] remain = new Object[arr.Length - length];


            //for (int i = 0; i != arr.Length; i++)
            //    for (int j = 0; j != falsyValues.Length; j++)
            //        if (arr[i] != falsyValues[j] || !arr[i].Equals(falsyValues[j]))
            //            remain[] = arr[i];
                            



            string safe = "stop";

            return arr;
        }
    }
}
