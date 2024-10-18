namespace Studia;

internal class GotoImplement
{
    public void GoTo()
    {
        string xInput = Console.ReadLine();

        string[] inputSplited = xInput.Split(" ");

        int x = int.Parse(inputSplited[0]);
        int y = int.Parse(inputSplited[1]);
        int z = int.Parse(inputSplited[2]);

    FirstCondition:
        {
            if (x > 0)
                goto SecondCondition;
            else
                Console.Write("E");
            Console.Write("G");
            Console.WriteLine();
            return;
        }

    SecondCondition:
        if (y > 0)
        {
            x = x - 1;
            y = y - 1;
            Console.Write("C");
            goto FirstCondition;
        }
        else
        {
            Console.Write("D");
            goto ThirdCondition;
        }

    ThirdCondition:
        {
            if (z > 0)
            {
                Console.WriteLine();
                return;
            }
            else
            {
                Console.Write("G");
                Console.WriteLine();
                return;
            }
        }
    }
    public void WhileUse()
    {
        string xInput = Console.ReadLine();

        string[] inputSplited = xInput.Split(" ");

        int x = int.Parse(inputSplited[0]);
        int y = int.Parse(inputSplited[1]);
        int z = int.Parse(inputSplited[2]);

        while (x > 0)
        {
            while (y > 0)
            {
                x = x - 1;
                y = y - 1;
                Console.Write("C");

                if (x <= 0)
                {
                    Console.Write("E");
                    Console.Write("G");
                    Console.WriteLine();
                    return;
                }
            }

            Console.Write("D");

            if (z > 0)
            {
                Console.WriteLine();
                return;
            }

            Console.Write("G");
            Console.WriteLine();
            return;
        }

        Console.Write("E");
        Console.Write("G");
        Console.WriteLine();
        return;
    }
    public void UsingForLoop()
    {
        string xInput = Console.ReadLine();

        string[] inputSplited = xInput.Split(" ");

        int x = int.Parse(inputSplited[0]);
        int y = int.Parse(inputSplited[1]);
        int z = int.Parse(inputSplited[2]);

        for (; x > 0;)
        {
            for (; y > 0;)
            {
                x--;
                y--;
                Console.Write("C");

                if (x <= 0)
                {
                    Console.Write("E");
                    Console.Write("G");
                    Console.WriteLine();
                    return;
                }
            }

            Console.Write("D");

            if (z > 0)
            {
                Console.WriteLine();
                return;
            }

            Console.Write("G");
            Console.WriteLine();
            return;
        }

        Console.Write("E");
        Console.Write("G");
        Console.WriteLine();
        return;

    }

}
