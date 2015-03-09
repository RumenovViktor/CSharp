using System;
using System.Collections.Generic;

// Write a program to convert binary numbers to hexadecimal numbers (directly).

class BinaryToHexadecimal
{
    static void Main()
    {
        string binaryNumber = Console.ReadLine();

        ToHexadecimal(binaryNumber);

        Console.WriteLine();
    }

    static void ToHexadecimal(string binaryNumber)
    { 
        // 1001 0100
        string number = "";

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            number += binaryNumber[i];

            if (number.Length == 4)
            {
                NumbersInHex(number);
                number = "";
            }
        }
    }

    static void NumbersInHex(string number)
    {
        char digit = ' ';
        switch (number)
        {
            case "0000":
                digit = '0';//
                break;
            case "0001":
                digit = '1';//
                break;
            case "0010":
                digit = '2';//
                break;
            case "0100":
                digit = '4';//
                break;
            case "1000":
                digit = '8';//
                break;
            case "1001":
                digit = '9';//
                break;
            case "1010":
                digit = 'A';//
                break;
            case "1011":
                digit = 'B';//
                break;
            case "0011":
                digit = '3';//
                break;
            case "0101":
                digit = '5';//
                break;
            case "0110":
                digit = '6';//
                break;
            case "0111":
                digit = '7';//
                break;
            case "1100":
                digit = 'C';//
                break;
            case "1101":
                digit = 'D';
                break;
            case "1111":
                digit = 'F';
                break;
            case "1110":
                digit = 'E';
                break;
        }

        Console.Write(digit);
    }
}