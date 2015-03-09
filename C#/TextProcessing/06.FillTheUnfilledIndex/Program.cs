using System;
using System.Collections.Generic;
using System.Text;

//Write a program that reads from the console a string of maximum 20 characters. If
//the length of the string is less than 20, the rest of the characters should be filled with '*'. 
//Print the result string into the console.

class FillTheUnfilledIndexes
{
    static void Main()
    {
        const int wantedLength = 20;
        StringBuilder newStr = new StringBuilder();

        string str = Console.ReadLine();
        newStr.Insert(0, str);

        if (str.Length < wantedLength)
        {
            int endIndex = str.Length;

            for (int i = endIndex; i < wantedLength; i++)
            {
                newStr.Append('*');
            }
        }

        for (int i = 0; i < newStr.Length; i++)
        {
            Console.Write(newStr[i]);
        }

        Console.WriteLine();
    }
}