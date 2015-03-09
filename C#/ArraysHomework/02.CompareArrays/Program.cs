using System;
/*
 * Write a program that reads two arrays from the console and compares them element by element.
 */
class CompareElements
{
    static void Main()
    {
        Console.Write("Enter the length of the first array: ");
        int firstLength = int.Parse(Console.ReadLine());

        Console.Write("Enter the length of the second array: ");
        int secondLength = int.Parse(Console.ReadLine());

        int [] firstArray = new int [firstLength];
        int [] secondArray = new int [secondLength];
        bool areEqual = false;

        if (firstLength != secondLength)
        {
            Console.WriteLine("Are they equal ? {0}", areEqual);
            return;
        }
        else
        {
            Console.WriteLine("First array elements: ");
            for (int i = 0; i < firstLength; i++)
            {
                Console.Write("[{0}]: ", i);
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Second array elements: ");
            for (int i = 0; i < secondLength; i++)
            {
                Console.Write("[{0}]: ", i);
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < firstLength; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine("Are they equal ? {0}", areEqual);
                    return;
                }
            }
        }
        areEqual = true;
        Console.WriteLine("Are they equal ? {0}", areEqual);
    }
}
