using System;
using System.Collections.Generic;

// Write a program to convert decimal numbers to their binary representation.

class DecimalToBinary
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        BinaryRepresentation(number);
    }

    static void BinaryRepresentation(int number)
    {
        List<int> bits = new List<int>(); // Here I will store the bits

        while (number != 0)
        {
            int bit = number % 2; // This way I get the bits
            number /= 2;
            bits.Add(bit); // Add it to the list
        }

        // Reverse the list to get the binary representation
        for (int i = bits.Count - 1; i >= 0; i--)
        {
            Console.Write(bits[i]);
        }

        Console.WriteLine();
    }
}