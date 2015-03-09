using System;
/*
 * Write a program that finds the maximal increasing sequence in an array. 
*/
class EncreasingElements
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 8, 4, 5, 6, 7, 8};
        int currentNumber = numbers[0];
        int taker = 0;
        int counter = 1;
        int maxCounter = 1;

        for (int i = 1; i < numbers.Length; i++)
        {
            currentNumber = numbers[i - 1];

            if (currentNumber == numbers[i] - 1)
            {
                counter++;
            }
            else
            {
                counter = 1;
            }
            if (counter > maxCounter)
            {
                maxCounter = counter;
                taker = currentNumber;
            }

            currentNumber = numbers[i - 1];
        }
        
        int [] elements = new int [maxCounter];

        for (int i = maxCounter - 1; i >= 0; i--)
        {
            elements[i] = taker + 1;
            taker--;
        }

        for (int i = 0; i < elements.Length; i++)
        {
            Console.Write(elements[i] + " ");
        }
        Console.WriteLine();
    }
}