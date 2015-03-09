using System;
using System.Collections.Generic;

// Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToDecimal
{
    static void Main()
    {
        string hexadecimalNumber = Console.ReadLine();

        ToDecimal(hexadecimalNumber);
    }

    static void ToDecimal(string hexadecimalNumber)
    {
        int result = 0, power = hexadecimalNumber.Length - 1;

        for (int i = 0; i < hexadecimalNumber.Length; i++)
        {
            // Check if the element is not a digit
            if (!Char.IsDigit(hexadecimalNumber[i]))
            {
                int takeIntRepresentation = 0;
                takeIntRepresentation = ConvertToNumber(hexadecimalNumber[i]); // Takes the number that is under the letter
                result += takeIntRepresentation * (int)Math.Pow(16, power);
                power--;
            }
            else
            {
                int digit = hexadecimalNumber[i] - '0';
                result += digit * (int)Math.Pow(16, power);
                power--;
            }
        }

        Console.WriteLine(result);
    }

    static int ConvertToNumber(char digit)
    {
        int decimalDigit = 0;

        switch (digit)
        {
            case 'A':
                decimalDigit = 10;
                break;
            case 'B':
                decimalDigit = 11;
                break;
            case 'C':
                decimalDigit = 12;
                break;
            case 'D':
                decimalDigit = 13;
                break;
            case 'E':
                decimalDigit = 14;
                break;
            case 'F':
                decimalDigit = 15;
                break;
        }

        return decimalDigit;
    }
}