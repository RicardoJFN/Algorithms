using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Mutations
    {
        public static bool Mutation(string[] arr)
        {

            int[] check = new int[arr[1].Length];
            string first = arr[0].ToLower();
            string second = arr[1].ToLower();

            for (int i = 0; i != second.Length; i++)
                for (int j = 0; j != first.Length; j++)
                    if (second[i] == first[j])
                            check[i] = 1;

            int count = 0;
            foreach (int item in check)
            {
                count += item;

                if (count == check.Length)
                    return true;
            }
                 

            return false;
        }
    }
}
