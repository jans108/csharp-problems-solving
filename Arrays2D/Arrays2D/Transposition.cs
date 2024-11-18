namespace Arrays2D;

public class Transposition
{
    public void MakingTransposition()
    {
        string arrayDimensions = Console.ReadLine();

        string[] splited = arrayDimensions.Split(' ');

        int n = int.Parse(splited[0]);

        int m = int.Parse(splited[1]);

        int[,] array2D = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            string data = Console.ReadLine();

            string[] splitedData = data.Split(' ');

            for (int j = 0; j < m; j++)
            {
                array2D[i, j] = int.Parse(splitedData[j]);
            }
        }

        int[,] invertedArray = new int[m, n];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                invertedArray[j, i] = array2D[i, j];
            }
        }

        for (int i = 0; i < m; i++)
        {
            if (i != 0)
            {
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                Console.Write($"{invertedArray[i, j]} ");
            }
        }
    }
}
