using System;
using System.Collections.Generic;

class PrintInVariousFormats
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        PrintingTheEnteredNumberInVariousFormats(number);
    }

    private static void PrintingTheEnteredNumberInVariousFormats(int number)
    {
        Console.WriteLine("Decimal number: {0,15}", number);
        Console.WriteLine("Hexadecimal number: {0,15:X4}", number);
        Console.WriteLine("Percentage: {0,15:P}", number);
        Console.WriteLine("Scientific: {0,15:E}", number);
    }
}