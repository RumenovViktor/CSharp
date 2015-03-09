using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NumberInArray
{
    static void Main()
    {
        Console.Write("Length of the array: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int [n];
        Console.Write("Wanted number: ");
        int wantedElement = int.Parse(Console.ReadLine());

        numbers = EnterElements(numbers);

        PrintElements(numbers);

        int count = CountOfEqualElements(wantedElement, numbers);

        Console.WriteLine("The element {0} is found {1} times in the array. ", wantedElement, count);
    }

    static int[] EnterElements(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }
        
        return numbers;
    }

    static void PrintElements(int[] numbers)
    {
        Console.Write("The array: ");

        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static int CountOfEqualElements(int wantedNumber, int[] numbers)
    {
        int counter = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == wantedNumber)
            {
                counter++;
            }
        }

        return counter;
    }
}

