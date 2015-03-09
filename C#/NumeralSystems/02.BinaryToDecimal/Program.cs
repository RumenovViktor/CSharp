using System;
using System.Collections.Generic;

// Write a program to convert binary numbers to their decimal representation.

class BinaryToDecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        int decimalNumber = ToDecimal(binaryNumber);

        Console.WriteLine(decimalNumber);
    }

    static int ToDecimal(string binaryNumber)
    {
        int decimalNumber = 0;
        int power = binaryNumber.Length - 1;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += (binaryNumber[i] - '0') * (int)Math.Pow(2, power);
            power--;
        }

        return decimalNumber;
    }
}