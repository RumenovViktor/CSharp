using System;
/* 
 *Write a program that finds the maximal sequence of equal elements in an array. 
 */
class MostCommonElement
{
    static void Main()
    {
        int maxCounter = 0;
        int counter = 1;
        int currentNumber;
        int taker = 0;
        int[] array = { 2, 1, 1, 3, 3, 3, 5, 12, 12 };

        currentNumber = array[0];

        for (int i = 1; i < array.Length; i++)
        {   
            if (currentNumber == array[i])
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

            currentNumber = array[i];
        }

        Console.Write("{ ");
        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(taker + " ");
        }
        Console.Write("}");

        Console.WriteLine();
    }
}
