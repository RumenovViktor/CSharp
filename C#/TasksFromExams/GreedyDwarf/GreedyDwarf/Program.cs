using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class GreedyDwarf
{
    static void Main()
    {
        string[] valleyNumbers = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int n = int.Parse(Console.ReadLine());
        int[] parsedValleyNumbers = new int[valleyNumbers.Length];

        for (int i = 0; i < parsedValleyNumbers.Length; i++)
        {
            parsedValleyNumbers[i] = int.Parse(valleyNumbers[i]);
        }

        int maxCoins = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int coins = PatternNumbers(parsedValleyNumbers);
           
            if (coins > maxCoins)
            {
                maxCoins = coins;
            }
        }

        Console.WriteLine(maxCoins);
    }

    static int PatternNumbers(int[] valley)
    {
        string[] patternInString = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
        int[] pattern = new int[patternInString.Length];

        for (int i = 0; i < pattern.Length; i++)
        {
            pattern[i] = int.Parse(patternInString[i]);
        }

        int coinSum = valley[0];
        List<int> takenIndexes = new List<int>();
        takenIndexes.Add(0);
        int currentPosition = 0;

        while (true)
        {
            for (int i = 0; i < pattern.Length; i++)
            {
                int nextMove = currentPosition + pattern[i];

                if (nextMove < valley.Length && nextMove >= 0 && !takenIndexes.Contains(nextMove))
                {
                    coinSum += valley[nextMove];
                    takenIndexes.Add(nextMove);
                    currentPosition = nextMove;
                }
                else
                {
                    return coinSum;
                }
            }
        }
    }
}