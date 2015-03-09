using System;
using System.Collections.Generic;

// Write a program that fills and prints a matrix of size (n, n).

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0; int col = 0;
        int number = 0;

        while (true)
        {
            if (row < n)
            {
                number++;
                matrix[row, col] = number;
                row++;
            }
            else
            {
                row = 0;
                col++;
            }

            if (col == n)
            {
                break;
            }
        }

        for (int rowMatrix = 0; rowMatrix < n; rowMatrix++)
        {
            for (int colMatrix = 0; colMatrix < n; colMatrix++)
            {
                Console.Write((matrix[rowMatrix, colMatrix] + " ").PadLeft(3));
            }
            Console.WriteLine();
        }
    }
}