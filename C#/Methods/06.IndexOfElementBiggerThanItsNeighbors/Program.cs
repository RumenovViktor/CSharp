using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class IndexOfElement
{
    static void Main()
    {
        Console.Write("Length: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int [length];

        numbers = InitialiseArray(numbers);

        PrintArray(numbers);

        int index = CheckNeighbors(numbers);

        Console.WriteLine(index);
    }

    static int[] InitialiseArray(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]", i);
            numbers[i] = int.Parse(Console.ReadLine());
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

    static int CheckNeighbors(int[] numbers)
    {
        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                return i;
            }
        }

        return -1;
    }
}
