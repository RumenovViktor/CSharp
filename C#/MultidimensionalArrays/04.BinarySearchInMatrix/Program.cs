using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinSearchInMatrix
{
    static void Main()
    {
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int [length];
        int k = int.Parse(Console.ReadLine());
        int index = 0;

        for (int i = 0; i < length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers);

        index = Array.BinarySearch(numbers, k);

        // If the element doesn't exist we start looking for the element that's <= to k
        while (index < 0)
        {
            k--;
            index = Array.BinarySearch(numbers, k);
        }

        Console.WriteLine("numbers[{1}]: {0}", numbers[index], index);
    }
}
