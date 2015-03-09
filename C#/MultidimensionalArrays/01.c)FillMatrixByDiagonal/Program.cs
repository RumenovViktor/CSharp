using System;

public class FillMatrixByDiaganol
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int number = 1;

        for (int row = 0; row <= n - 1; row++)
        {
            for (int col = 0; col <= row; col++)
            {
                matrix[n - row + col - 1, col] = number;
                number++;
            }
        }

        for (int row = n - 2; row >= 0; row--)
        {
            for (int col = row; col >= 0; col--)
            {
                matrix[row - col, n - col - 1] = number;
                number++;
            }
        }

        PrintMatrix(matrix);
    }

    static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                Console.Write((matrix[i, j] + " ").PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}