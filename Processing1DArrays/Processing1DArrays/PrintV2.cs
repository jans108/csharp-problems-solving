using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Processing1DArrays
{
    public static class PrintV2Array
    {
        public static void Print(int[] a, int[] b)
        {
            int?[] duplicates = new int?[a.Length + b.Length];

            int counter = 0;

            int?[] uniqueVal = new int?[a.Length + b.Length];

            for (int i = 0; i < a.Length; i++)
            {
                if (!Array.Exists(b, x => x == a[i]) && !Array.Exists(duplicates, x => x == a[i]))
                {
                    duplicates[counter] = a[i];

                    uniqueVal[counter] = a[i];

                    counter++;
                }
            }

            for (int i = 0; i < b.Length; i++)
            {
                if (!Array.Exists(a, x => x == b[i]) && !Array.Exists(duplicates, x => x == b[i]))
                {
                    duplicates[counter] = b[i];

                    uniqueVal[counter] = b[i];

                    counter++;
                }
            }

            if (counter == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            Array.Sort(uniqueVal, 0, uniqueVal.Length);

            int nullCounter = 0;

            foreach (var item in uniqueVal)
            {
                if (item == null)
                {
                    nullCounter++;
                }
            }

            int?[] arrayWithoutNulls = new int?[uniqueVal.Length - nullCounter];

            Array.Copy(uniqueVal, nullCounter, arrayWithoutNulls, 0, arrayWithoutNulls.Length);

            for (int i = 0; i < arrayWithoutNulls.Length; i++)
            {
                Console.Write($"{arrayWithoutNulls[i]} ");
            }
        }
    }
}
