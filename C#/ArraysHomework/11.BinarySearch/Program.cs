using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Enter lenth of the array: ");
        int length = int.Parse(Console.ReadLine());
        int[] numbers = new int [length];
        Console.Write("Enter the number:");
        int wantedNumber = int.Parse(Console.ReadLine());

        // Initializing the array
        for (int i = 0; i < length; i++)
        {
            Console.Write("[{0}]: ", i);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // For the binary search sort to be done, we need to sort the array first
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] > numbers[j])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        Console.WriteLine();
        foreach (var item in numbers)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");
        int lowPosition = 0;
        int highPosition = numbers.Length - 1;

        while (highPosition >= lowPosition)
        {
            int currentPosition = lowPosition + ((highPosition - lowPosition)/2);

            if (wantedNumber > numbers[currentPosition])
            {
                lowPosition = currentPosition + 1;
            }
            else if (wantedNumber < numbers[currentPosition])
            {
                highPosition = currentPosition - 1;
            }
            else
            {
                Console.WriteLine(currentPosition);
                return;
            }
        }

        Console.WriteLine("No such element.");
        return;
    }
}