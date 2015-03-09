using System;
using System.Linq;

class JoroTheRabbit
{
    static void Main()
    {
        // Read input string
        string[] separator = { ", " };
        string[] input = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
        // Parse input numbers
        int[] field = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            field[i] = int.Parse(input[i]);
        }
        int positions = field.Length;

        // Result variable
        int maximumJumps = 0;

        // Start jumping
        // Number of loops is equal to the number of positions        
        for (int step = 1; step <= positions; step++)
        {
            // we start from each position
            for (int startingPosition = 0; startingPosition < positions; startingPosition++)
            {
                // Declare a bool array to mark visited positions
                //bool[] visited = new bool[positions];

                int currentPosition = startingPosition;
                int currentPositionValue = field[currentPosition];
                //visited[currentPosition] = true;
                int stepsMade = 1;
                while (true)
                {
                    currentPosition = (currentPosition + step) % positions;
                    if (field[currentPosition] > currentPositionValue)
                    {
                        //if (visited[currentPosition] == false)
                        //{
                        stepsMade++;
                        currentPositionValue = field[currentPosition];
                        //visited[currentPosition] = true;
                        //}                        
                    }
                    else
                    {
                        break;
                    }
                }
                if (stepsMade > maximumJumps)
                {
                    maximumJumps = stepsMade;
                }
            }
        }
        Console.WriteLine(maximumJumps);
    }
}