using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Intermediate
{
    public class SeekAndDestroy<T>
    {
       
        public static T[] Destroy(T[] arr, T valOne, T valTwo)
        {
            List<T> list = new List<T>();

            for (int i = 0; i != arr.Length; i++)
                if (!arr[i].Equals(valOne) || !arr[i].Equals(valTwo))
                    list.Add(arr[i]);

            return list.ToArray();
        }

        public static T[] Destroy(T[] arr, T valOne, T valTwo, T valThree)
        {
            return arr;
        }

    }
}
