using System;
/*
 * Write a program that finds the sequence of maximal sum in given array.  
*/
class MaximalSum
{
    static void Main()
    {
        int[] numbers = { 2, 3, -6, -1, 2, -1, 6, 4, 5, -8 };
       // { -1, 1, 2, 3, -2, -2};
        int maxResult = int.MinValue;
        int counter = 1;
        int sum = 0;
       // int currentNumber = 0;
        int index = 0;
        int maxCounter = 0;

        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = i - 1; j < numbers.Length; j++)
            {
                sum += numbers[j];

                if (sum > maxResult)            
                {
                    maxResult = sum;
                   // currentNumber = array[j];
                    index = j; // This way I get the index of the number
                    counter++;
                }

                if (counter > maxCounter)
                {
                    maxCounter = counter;
                }
            }
            counter = 1;
            sum = 0;
        }

        //Console.WriteLine(maxCounter);
        //Console.WriteLine(maxResult);
        //Console.WriteLine(index);

        for (int i = 0; i < maxCounter; i++)
        {
            Console.Write(numbers[index] + " ");
            index--;
        }
    }
}
