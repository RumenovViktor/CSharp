using System;
using System.Collections.Generic;

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int row = -1; int col = 0;
        int[,] matrix = new int[n, n];
        int number = 0;

        string direction = "down";

        while (true)
        {
            if (direction == "down")
            {
                if (row + 1 < n)
                {
                    number++;
                    row++;
                    matrix[row, col] = number;
                }
                else
                {
                    direction = "up";
                    col++;
                }
            }
            else if (direction == "up")
            {
                if (row >= 0)
                {
                    number++;
                    matrix[row, col] = number;
                    row--;
                }
                else
                {
                    direction = "down";
                    col++;
                }
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