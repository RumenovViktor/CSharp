using System;

/*
 * Write a program that finds the most frequent number in an array. 
*/

class MostCommonElement
{
    static void Main()
    {
        int[] numbers = {3, 4, 2, 41, 3, 2, 12, 2, 41, 3, 41, 41, 41 }; 
        int counter = 1;
        int maxCounter = 0;
        int currentNumber;
        int mostCommonElement = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            currentNumber = numbers[i];

            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (currentNumber == numbers[j])
                {
                    counter++;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                    mostCommonElement = currentNumber;
                }
            }

            counter = 1;
        }
       
        Console.WriteLine(mostCommonElement);
        Console.WriteLine(maxCounter);
    }
}

