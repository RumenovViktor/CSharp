using System;
using System.Collections.Generic;


//Write a program that reads a string, reverses it and prints the result at the console.
//Example: "sample"  "elpmas".

class ReverseStrings
{
    static void Main()
    {
        string expression = Console.ReadLine();

        ReverseString(expression);
    }

    static void ReverseString(string expression)
    {
        for (int i = expression.Length - 1; i >= 0; i--)
        {
            Console.Write(expression[i]);
        }

        Console.WriteLine();
    }
}