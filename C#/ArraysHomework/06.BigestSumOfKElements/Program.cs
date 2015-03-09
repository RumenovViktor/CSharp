using System;

class BiggestSum
{
    static void Main()
    {
        Console.Write("Enter how many elements there will be in the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Elements with biggest sum: ");
        int k = int.Parse(Console.ReadLine());

        int[] numbers = new int [n];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbers); // Sorting the array SURPRISE SURPRISE !!

        int index = numbers.Length - 1;

        for (int i = 0; i < k; i++)
        {
            Console.Write(numbers[index] + " ");
            index--;
        }

        Console.WriteLine();
    }
}