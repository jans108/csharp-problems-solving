namespace Studia
{
    internal class Zadania_petle
    {
        public void AscendingNumbersWithoutRemainder()
        {
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);

            //kod
            short conv1 = (short)dane[0];
            short conv2 = (short)dane[1];

            short a = Math.Min(conv1, conv2);
            short b = Math.Max(conv1, conv2);

            short c = (short)dane[2];

            if (c <= 0 || a >= b - 1)
            {
                Console.WriteLine("empty");
                return;
            }

            int count = 0;
            bool collectionHasValue = false;

            for (int i = a + 1; i < b; i++)
            {
                if (i % c == 0)
                {
                    count++;
                }
            }

            if (count <= 10)
            {
                for (int i = a + 1; i < b; i++)
                {
                    if (i % c == 0)
                    {
                        collectionHasValue = true;

                        if (i + c < b)
                        {
                            Console.Write($"{i}, ");
                        }
                        else
                        {
                            Console.Write($"{i}");
                        }
                    }
                }

                if (collectionHasValue == false)
                {
                    Console.WriteLine("empty");
                    return;
                }
            }

            else
            {
                for (int i = a + 1; i < a + 1 + c * 3; i++)
                {
                    if (i % c == 0)
                    {
                        Console.Write($"{i}, ");
                    }
                }

                Console.Write("..., ");

                for (int i = b - c * 2; i < b; i++)
                {
                    if (i % c == 0)
                    {
                        if (b <= i + c)
                        {
                            Console.Write($"{i}");
                        }
                        else
                        {
                            Console.Write($"{i}, ");
                        }
                    }
                }
            }
            return;
        }

        public void AscendingNumbers()
        {
            string wejscie = Console.ReadLine();
            int[] dane = Array.ConvertAll<string, int>(wejscie.Split(" "), int.Parse);

            //kod
            short conv1 = (short)dane[0];
            short conv2 = (short)dane[1];

            short a = Math.Min(conv1, conv2);
            short b = Math.Max(conv1, conv2);

            int amountOfIteration = 0;

            if (a < b - 1)
            {
                if (b - a < 12)
                {
                    for (int i = a; i < b - 1; i++)
                    {
                        amountOfIteration++;

                        if (amountOfIteration != b - a - 1)
                        {
                            Console.Write($"{i + 1}, ");

                        }
                        else
                        {
                            Console.WriteLine($"{i + 1}");
                        }
                    }
                }
                else
                {
                    for (int i = a; i < a + 3; i++)
                    {
                        Console.Write($"{i + 1}, ");
                    }

                    Console.Write($"..., ");



                    for (int i = b - 2; i < b; i++)
                    {
                        amountOfIteration++;

                        if (amountOfIteration == 1)
                            Console.Write($"{i}, ");

                        if (amountOfIteration == 2)
                            Console.Write($"{i}");
                    }
                }
            }
            else
                Console.Write("empty");

            return;
        }
    }
}
