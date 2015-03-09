using System;

class MaxSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int sum = 0;
        int maxSum = int.MinValue;

        if (n < 3 || m < 3)
        {
            Console.WriteLine("Can't generate needed sum with these values.");
            return;
        }

        int[,] matrix = new int [n, m];

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {

                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] + matrix[row + 1, col] + matrix[row + 1, col + 1]
                    + matrix[row + 2, col + 2] + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum > maxSum)
                {
                    maxSum = sum;
                }
            }
        }

        PrintMatrix(matrix);

        Console.WriteLine(maxSum);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write((matrix[i, j] + " ").PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}