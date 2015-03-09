using System;
using System.Collections.Generic;

class UnicodeCharacters
{
    static void Main()
    {
        string expression = Console.ReadLine();

        for (int i = 0; i < expression.Length; i++)
        {
            Console.Write("\\u{0:X4}", (int)expression[i]);
        }

        Console.WriteLine();
    }
}