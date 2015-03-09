using System;

/*
 * Write a program that finds in given array of integers a sequence of given sum S (if present). 
*/

class SequanceOfSum
{
    static void Main()
    {
        Console.Write("Size of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int [length];
        Console.Write("Wanted sum: ");
        int wantedSum = int.Parse(Console.ReadLine());
        int sum = 0;
        int index = 0;
        int counter = 1;

        // Initialising the array
        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            for (int j = i - 1; j < numbers.Length; j++)
            {
                sum += numbers[j];

                if (sum == wantedSum)
                {
                    index = j; // Getting the last index from the sequence
                    Console.WriteLine("The index of the number is: {0}", index - counter + 1); // From this formula, we get the first element from the sequense
                    Console.WriteLine("We found the sum: {0}", sum);
                    Console.WriteLine("Number of elements that make the sum: {0}", counter);
                    break;
                }

                counter++;
            }
            
            if (sum == wantedSum)
            {
                break;
            }

            sum = 0;
            counter = 1;
        }

        int startingElement = index - counter + 1;

        Console.Write("{ ");
        for (int i = 0; i < counter; i++)
        {
            Console.Write(numbers[startingElement] + " ");
            startingElement++;
        }
        Console.Write("}");
        Console.WriteLine();
    }
}