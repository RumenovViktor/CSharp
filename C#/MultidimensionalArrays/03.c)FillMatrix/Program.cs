using System;

class FillMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, n];
        int row = 0; int col = 0;
        int number = 1;

        string direction = "down";

        while (number <= n * n)
        {
            if (direction == "down" )
            {
                if (row + 1 < n && matrix[row + 1, col] == 0)
                {
                    matrix[row, col] = number;
                    number++;
                    row++;
                }
                else
                {
                    direction = "right";
                }
            }
            else if (direction == "right")
            {
                if (col + 1 < n && matrix[row, col + 1] == 0)
                {
                    matrix[row, col] = number;
                    number++;
                    col++;
                }
                else
                {
                    direction = "up";
                }
            }
            else if (direction == "up")
            {
                if (row - 1 >= 0 && matrix[row - 1, col] == 0)
                {
                    matrix[row, col] = number;
                    number++;
                    row--;
                }
                else
                {
                    direction = "left";
                }
            }
            else if (direction == "left")
            {
                if (col - 1 > 0 && matrix[row, col - 1] == 0)
                {
                    matrix[row, col] = number;
                    col--;
                    number++;
                }
                else
                {
                    direction = "down";
                }
            }

            if (number == n*n)
            {
                matrix[row, col] = number;
                break;
            }
        }

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