namespace Processing1DArrays;

public static class PrintArray
{
    public static void Print(int[] a, int[] b)
    {
        int?[] duplicates = new int?[a.Length];

        int counter = 0;

        for (int i = 0; i < a.Length; i++)
        {
            

            if (!Array.Exists(b, x => x == a[i]) && !Array.Exists(duplicates, x => x == a[i]))
            {
                duplicates[counter] = a[i];

                counter++;

                Console.Write($"{a[i]} ");
            }
        }

        if (counter == 0)
        {
            Console.WriteLine("empty");
        }

    }
}
