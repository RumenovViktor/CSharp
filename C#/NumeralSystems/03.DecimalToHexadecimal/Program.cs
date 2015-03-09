using System;
using System.Collections.Generic;

//Write a program to convert decimal numbers to their hexadecimal representation.

class DecimalToHexadecimal
{
    static void Main()
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        HexadecimalRepresentations(decimalNumber);
    }

    static char GetLetter(int reminder)
    {
        char letter = ' '; 
        switch (reminder)
        { 
            case 10:
                letter = 'A';
                break;
            case 11:
                letter = 'B';
                break;
            case 12:
                letter = 'C';
                break;
            case 13:
                letter = 'D';
                break;
            case 14:
                letter = 'E';
                break;
            case 15:
                letter = 'F';
                break;
        }

        return letter;
    }

    static void HexadecimalRepresentations(int decimalNumber)
    {
        List<char> digits = new List<char>();

        while (decimalNumber != 0)
        {
            int reminder = decimalNumber % 16;
            decimalNumber /= 16;

            if (reminder > 9)
            {
                char letter = GetLetter(reminder);
                digits.Add(letter);
            }
            else
            {
                char getReminderAsChar = (char)(reminder + '0');
                digits.Add(getReminderAsChar);
            }
        }

        for (int i = digits.Count - 1; i >= 0; i--)
        {
            Console.Write(digits[i]);
        }

        Console.WriteLine();
    }
}