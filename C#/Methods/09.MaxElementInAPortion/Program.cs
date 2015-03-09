using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MaxElementInAPortion
{
    static void Main()
    {
        Console.Write("Length: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int [length];
        Console.Write("Starting index: ");
        int startingIndex = int.Parse(Console.ReadLine());

        numbers = InitialiseArray(numbers); // The array takes the elements that are typed in the method

        int maxElement = ReturnMaxElement(startingIndex, numbers); 

        Console.WriteLine("Max element is: {0}\n", maxElement);

        Console.WriteLine("\nAscending: ");
        SortArrayAscending(numbers);
        PrintArray(numbers);

        Console.WriteLine("\nDescending: ");
        SortArrayDescending(numbers);
        PrintArray(numbers);
    }

    static int[] InitialiseArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        return numbers;
    }

    static int ReturnMaxElement(int startingIndex, int[] numbers)
    {
       int maxElement = int.MinValue;

        for (int i = startingIndex; i < numbers.Length; i++)
        {
            if (numbers[i] > maxElement)
            {
                maxElement = numbers[i];
            }
        }
        
        return maxElement;
    }

    static int[] SortArrayAscending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }

        return numbers;
    }

    static int[] SortArrayDescending(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] < numbers[j])
                {
                    int temp = numbers[j];
                    numbers[j] = numbers[i];
                    numbers[i] = temp;
                }
            }
        }

        return numbers;
    }

    static void PrintArray(int[] numbers)
    {
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();
    }
}